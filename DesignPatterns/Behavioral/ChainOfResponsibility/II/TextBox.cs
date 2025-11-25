namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class TextBox : Container
    {
        private string? _text;
        public string? Text
        {
            get => _text;
            set
            {
                _text = value;
                Console.WriteLine($"{Name} zmienił wartość na {value}");
            }
        }

        override protected void Click(bool handled)
        {
            if (!handled)
            {
                Console.WriteLine($"{Name} złapał focus");
            }
            base.Click(true);
        }
    }
}
