namespace acfour_Lluc_Velazquez
{
    internal class Program
    {
        const string Msg = "Quants nombres naturals vols?: ";
        const string DemanarNum = "Introdueix un nombre: ";
        const string FormatError = "No has introduit un nombre natural";
        const string OverflowError = "El nombre introduit es massa gran";
        const string Error = "Error inesperat";
        public static void Main()
        {
            int cuants = 0;

            Console.WriteLine(Msg);
            cuants = InsertNumException(cuants);

            int[] nums = new int[cuants];

            InsertNum(nums);
            WriteNum(nums);


            BubbleSort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }

        }

        public static void InsertNum(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(DemanarNum);
                nums[i] = InsertNumException(nums[i]);

            }
        }
        public static int InsertNumException(int num)
        {

            try
            {
                num = Int16.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(FormatError);
                num = 1;
            }
            catch (OverflowException)
            {
                Console.WriteLine(OverflowError);
                num = 1;
            }
            catch (Exception)
            {
                Console.WriteLine(Error);
                num = 1;
            }
            return num;
        }
        public static void WriteNum(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
        public static void BubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        int aux = nums[i];
                        nums[i] = nums[j];
                        nums[j] = aux;
                    }
                }
            }
        }
    }
}
