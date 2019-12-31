using System;

namespace lottoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int lottoLength = 6;
            int[] lottoNumbers = new int[lottoLength];

            Random random = new Random();

            int lottoNumberindex = 0;
            while (lottoNumberindex<lottoLength)
            {
                lottoNumbers[lottoNumberindex] = random.Next(1, 46);

                bool hasDuplicate = false;
                for (int i = 0; i<lottoNumberindex;i++)
                {
                    if(lottoNumbers[lottoNumberindex]==lottoNumbers[i])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }
                if(!hasDuplicate)
                {
                    lottoNumberindex++;
                }
            }
            Console.WriteLine("로또 번호 : ");
            for (int i = 0; i<lottoLength;i++)
            {
                Console.Write(lottoNumbers[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
