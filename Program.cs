namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dataLength = 0;
            do
            {
                dataLength = Int32.Parse(Console.ReadLine());
            } while (!(dataLength >= 1 && dataLength <= 100));

            string[] brandName = new string[dataLength];
            int[] brandAmount = new int[dataLength];

            for (int i = 0; i < dataLength; i++)
            {
                string nameInput = Console.ReadLine();
                brandName[i] = nameInput;
                int amountInput = Convert.ToInt32(Console.ReadLine());
                brandAmount[i] = amountInput;
            }

            string firstBrand = brandName[0];
            int totalAmount = 0;

            for (int i = 0; i < dataLength; i++)
            {
                if (firstBrand == brandName[i])
                {
                    totalAmount += brandAmount[i];
                }
            }

            Console.WriteLine(totalAmount);
        }
    }
}
