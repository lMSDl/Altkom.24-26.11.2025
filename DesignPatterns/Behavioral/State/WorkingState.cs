namespace DesignPatterns.Behavioral.State
{
    internal class WorkingState : State
    {
        private readonly CancellationTokenSource _cancellationTokenSource;
        public WorkingState(CoffeeMachine coffeeMachine, int time) : base(coffeeMachine)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Delay(TimeSpan.FromMilliseconds(time), _cancellationTokenSource.Token)
                .ContinueWith(t =>
                {
                    coffeeMachine.State = new IdleState(coffeeMachine);
                    _cancellationTokenSource.Dispose();
                });
        }

        public override void Large()
        {
            System.Console.WriteLine("Anulacja");
            _cancellationTokenSource.Cancel();
        }

        public override void Small()
        {
            Large();
        }
    }
}