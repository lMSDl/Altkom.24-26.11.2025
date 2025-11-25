namespace DesignPatterns.Structural.Bridge
{
    internal abstract class Color
    {
        public Brightness? Brightness { get; set; }

        public override string ToString()
        {
            return (Brightness is not null ? $"{Brightness}" : "") + GetType().Name;
        }
    }
}
