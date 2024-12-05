namespace acfour_Lluc_Velazquez
{
    internal class Program
    {
        const string Msg = "Quants nombres naturals vols?: ";
        const string DemanarNum = "Introdueix un nombre: ";
        static void Main()
        {
            int cuants = 0;
            try
            {
                Console.WriteLine(Msg);
                cuants = Int16.Parse(Console.ReadLine());
            }
            catch (InvalidDataException)
            {

            }
            
            int[] nums = new int[cuants];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(DemanarNum);
                nums[i] = Int16.Parse(Console.ReadLine());
            }
            for (int i = 0;i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
    }
}
