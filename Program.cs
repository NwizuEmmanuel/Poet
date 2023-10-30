namespace Poet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = "Mark is aboy in antartica of Silic. Mark was a child in brewing anger with ada.";
            string[] stringSeparator = new string[] { " " };

            string[] result = words.Split(stringSeparator, StringSplitOptions.None);
            string[] finalResult = Array.FindAll(result, item => item.StartsWith("a"));

            int lineCounter = 0;
            foreach (string str in finalResult)
            {
                Console.Write(str + " ");
                lineCounter++;
                if (lineCounter == 3)
                {
                    Console.WriteLine();
                    lineCounter = 0;
                }

            }
        }
    }
}