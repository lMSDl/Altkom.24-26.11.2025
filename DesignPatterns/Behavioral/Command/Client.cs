namespace DesignPatterns.Behavioral.Command
{
    internal class Client
    {
        public static void Execute()
        {
            var garden = new Garden(5);

            var command1 = new PlantCommand("Rose", garden);
            var command2 = new PlantCommand("Tulip", garden);
            var command3 = new RemoveCommand("Rose", garden);
            var command4 = new RemoveCommand("Tulip", garden);


            var plantRoseButton = new CommandInvoker(command1);
            var plantTulipButton = new CommandInvoker(command2);
            var removeRoseButton = new CommandInvoker(command3);
            var removeTulipButton = new CommandInvoker(command4);

            Console.WriteLine(garden);

            plantRoseButton.Click();
            plantRoseButton.Click();
            plantRoseButton.Click();

            Console.WriteLine(garden);

            plantTulipButton.Click();
            plantTulipButton.Click();
            plantTulipButton.Click();

            Console.WriteLine(garden);

            removeRoseButton.Click();
            removeTulipButton.Click();
            removeTulipButton.Click();
            removeTulipButton.Click();

            Console.WriteLine(garden);

            CommandInvoker.Reverse();
            CommandInvoker.Reverse();
            CommandInvoker.Reverse();
            CommandInvoker.Reverse();

            Console.WriteLine(garden);
        }
    }
}
