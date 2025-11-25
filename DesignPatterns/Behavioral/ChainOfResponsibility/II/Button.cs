namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Button : Component
    {
        public required Func<bool> OnClick { get; init; }

        protected override void Click(bool handled)
        {
            if (!handled && OnClick())
                base.Click(true);
            else
                base.Click(handled);
        }
    }
}
