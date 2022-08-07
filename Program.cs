using System;

namespace Tasks_7aug
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{number} has {NumLenght(number)} digits");

            #endregion
            #region Task2
            //string text = Console.ReadLine();
            //Console.WriteLine(VowelLetter(text));
            #endregion
            #region Task3
            int[] numbers = { 1, 4, 4, 5, 6, 7, 89,  4, 42, 0 };
            ChangeMaxMin(ref numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            



            #endregion
            #region Task4
            //int[] numbers = { 32, 4, 2, 2324, 5, 3, 2, 4, 5331, 3, 2, 66, 8 };
            //int numb = 99;
            //Console.WriteLine(CheckNumber(numb,numbers));

            #endregion
        }
        #region Task1
        //static int NumLenght(int numb)
        //{
        //    int temp = numb;
        //    int count = 1;
        //    int i = 10;
        //    if (temp < 0)
        //        temp = temp * (-1);



        //    while (i < temp)
        //      {
        //            temp = temp / 10;
        //            count++;

        //      }
        //    return count;

        //}


        #endregion
        #region Task2
        //static int VowelLetter(string text)
        //{
        //    int count = 0;
        //    #region Way1
        //    char[] vowels = { 'a', 'ı', 'o', 'u', 'e', 'ə', 'i', 'ö', 'ü' };
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        for (int k = 0; k < vowels.Length; k++)
        //        {
        //            if (text[i] == vowels[k])
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    #endregion 
        //    #region Way2
        //    //for (int i = 0; i < text.Length; i++)
        //    //{
        //    //    if (text[i]=='a' || text[i]=='ı' || text[i]=='ə' || text[i]=='ö' || text[i]=='ü' || text[i]=='e' || text[i]=='o' ||text[i]=='u' || text[i]=='i')
        //    //    {
        //    //        count++;
        //    //    }
        //    //}
        //    #endregion
        //    return count;



        //}
        #endregion
        #region Task3
        static void ChangeMaxMin(ref int[] numbers)
        {
            int min = 0;
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[max])
                {
                    max = i;
                }
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[min])
                {
                    min = j;
                }
            }
            numbers[max] = numbers[max] + numbers[min];
            numbers[min] = numbers[max] - numbers[min];
            numbers[max] = numbers[max] - numbers[min];

        }


        #endregion
        #region Task4
        //static bool CheckNumber(int numb, int[] numbers)
        //{
        //    bool check = false;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i]==numb)
        //        {
        //            check = true;
        //            break;
        //        }
        //    }
        //    return check;
        //}
        #endregion
    }
}
