
using System.Net.Quic;

namespace MST
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Riyazi emeliyatlar menyusuna xos gelmisiniz.");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n" +
                    "1. Toplama\n" +
                    "2. Cixma\n" +
                    "3. Vurma\n" +
                    "4. Bolme\n" +
                    "5. Ust Alma\n" +
                    "6. Cixis\n");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    int cem = Toplama();
                }
                else if (input == 2)
                {
                    int ferq = Cixma();
                }
                else if (input == 3)
                {
                    int hasill = Vurma();
                }
                else if (input == 4)
                {
                    float qismet = Bolme();
                }
                else if (input == 5)
                {
                    int ustAlma = UstAlma();
                }
                else if (input == 6)
                {
                    flag = false;
                }
            }

        }
        public static int Toplama()
        {
            Console.Write("1. ededi daxil edin: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("2. ededi daxil edin: ");
            int number2 = int.Parse(Console.ReadLine());
            int cem = number1 + number2;
            Console.WriteLine($"Iki ededin cemi: {cem}");
            return cem;
        }
        public static int Cixma()
        {
            Console.Write("1. ededi daxil edin: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("2. ededi daxil edin: ");
            int number2 = int.Parse(Console.ReadLine());
            int ferq = number2 - number1;
            Console.WriteLine($"iki eded arasindaki ferq: {ferq}");
            return ferq;
        }
        public static int Vurma()
        {
            Console.Write("1. ededi daxil edin: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("2. ededi daxil edin: ");
            int number2 = int.Parse(Console.ReadLine());
            int hasil = number1 * number2;
            Console.WriteLine($"iki ededin hasili: {hasil}");
            return hasil;
        }
        public static float Bolme()
        {
            Console.Write("1. ededi daxil edin: ");
            float number1 = int.Parse(Console.ReadLine());
            Console.Write("2. ededi daxil edin: ");
            float number2 = int.Parse(Console.ReadLine());
            float qismet = number1 / number2;
            Console.WriteLine($"iki ededin qismeti: {qismet}");
            return qismet;
        }
        public static int UstAlma()
        {
            Console.Write("Ededi daxil edin: ");
            int number1 = int.Parse(Console.ReadLine());
            int kvadrat = number1 * number1;
            Console.WriteLine($"Ededin kvadrati: {kvadrat}");
            return kvadrat;
        }
    }
}
