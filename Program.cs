namespace Utepitok_Csoke_Balazs_11A
{
    internal class Program
    {
        static int[] DolgozokTMB = new int[18];
        static double[] UthosszTMB = new double[18];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Bugrol();
            Utepitok();
        }

        private static void Utepitok()
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
            Feladat9();
        }

        private static void Feladat9()
        {
            Console.WriteLine("\n9. Feladat: ");
            int db = 0;
            double CelUt = 0;
            while(CelUt < 305)
            {
                CelUt += UthosszTMB[db];
                db++;
            }
            Console.WriteLine($"A célmagassághoz ennyi nap kell minimum: {db}. Út hossza: {CelUt}");
        }

        private static void Feladat8()
        {
            Console.WriteLine("\n8. Feladat: ");
            int CsereDolgozo;
            double CsereUthossz;
            for(int i = 0; i < UthosszTMB.Length; i++)
            {
                for(int j = 0; j < UthosszTMB.Length-1; j++)
                {
                    if (UthosszTMB[j]>UthosszTMB[j+1])
                    {
                        CsereUthossz= UthosszTMB[j];
                        CsereDolgozo= DolgozokTMB[j];
                        UthosszTMB[j]=UthosszTMB[j + 1];
                        DolgozokTMB[j]=DolgozokTMB[j + 1];
                        UthosszTMB[j + 1]=CsereUthossz;
                        DolgozokTMB[j + 1]=CsereDolgozo;
                    }
                }
            }
            for(int i = 0; i< 18; i++)
            {
                Console.WriteLine($"{i+1}. nap -> Dolgozó száma: {DolgozokTMB[i]}, Úthossza: {UthosszTMB[i]}");
            }
        }

        private static void Feladat7()
        {
            Console.WriteLine("\n7. Feladat: ");
            bool VanE=false;
            Console.WriteLine($"Kérem adjon meg egy számot 8 és 12 között");
            int KeresSzam = int.Parse( Console.ReadLine()!);
            for(int i=0;i<DolgozokTMB.Length;i++)
            {
                if (KeresSzam==DolgozokTMB[i])
                {
                    VanE=true;
                    break;
                }
            }
            if (VanE==true) { Console.WriteLine("Igen volt ilyen nap"); }
            else { Console.WriteLine("Nem,  nem volt ilyen nap"); }
        }

        private static void Feladat6()
        {
            Console.WriteLine("\n6. Feladat: ");
            int db65 = 0;
            for(int i=0;i<UthosszTMB.Length;i++)
            {
                if (db65<UthosszTMB[i])
                {
                    db65++;
                }
            }
            Console.WriteLine($"{db65} alkalommal volt 65 méter feletti");
        }

        private static void Feladat5()
        {
            Console.WriteLine("\n5. Feladat:(Nem kötelező feladat) ");
            int MinDolgozok = int.MaxValue;
            int MinHely = 0;
            for(int i=0; i<DolgozokTMB.Length; i++)
            {
                if (MinDolgozok>DolgozokTMB[i])
                {
                    MinDolgozok=DolgozokTMB[i];
                }
            }
            Console.WriteLine($"Min dolgozók száma: {MinDolgozok}");
        }

        private static void Feladat4()
        {
            Console.WriteLine("\n4. Feladat: ");
            double MaxHossz = double.MinValue;
            int MaxHely = 0;
            int DolgozokSzama = 0;
            for(int i = 0; i<UthosszTMB.Length; i++)
            {
                if (MaxHossz<UthosszTMB[i])
                {
                    MaxHossz= UthosszTMB[i];
                    DolgozokSzama=DolgozokTMB[i];
                }
            }
            Console.WriteLine($"Max út hossza: {MaxHossz}, dolgozók száma: {DolgozokSzama}");
        }

        private static void Feladat3()
        {
            Console.WriteLine("\n3. Feladat: ");
            int DolgozokOssz = 0;
            for(int i=0; i<18; i++)
            {
                DolgozokOssz+=DolgozokTMB[i];
            }
            double AtlagDolgozok = (double)DolgozokOssz/DolgozokTMB.Length;
            Console.WriteLine($"Dolgozók számának átlaga: {AtlagDolgozok:0.00}");
        }

        private static void Feladat2()
        {
            Console.WriteLine("\n2. Feladat: ");
            for(int i = 0; i<18; i++)
            {
                Console.WriteLine($"{i+1}.nap -> dolgozók száma: {DolgozokTMB[i]} -> {UthosszTMB[i]:0.00}");
            }
        }

        private static void Feladat1()
        {
            //Console.WriteLine("1. Feladat: ");
            for(int i = 0; i<18; i++)
            {
                DolgozokTMB[i]=rnd.Next(8, 13);
                UthosszTMB[i]=rnd.Next(5055, 7555)/100.00;
            }
        }

        private static void Bugrol()
        {
            int[] FeltoltTMB = { 23, 52, 62, 42, 73, 45, 32, 25, 36, 58, 39, 42, 12, 40 };
            int CsereSzam;
            for(int i=0; i<FeltoltTMB.Length; i++)
            {
                for(int j=0; j<FeltoltTMB.Length-1; j++)
                {
                    if (FeltoltTMB[i]<FeltoltTMB[j+1])
                    {
                        CsereSzam = FeltoltTMB[j];
                        FeltoltTMB[j] = FeltoltTMB[j + 1];
                        FeltoltTMB[j + 1] = CsereSzam;
                    }
                }
            }
            for(int i=0; i<FeltoltTMB.Length; i++)
            {
                Console.WriteLine($"{FeltoltTMB[i]}");
            }
        }
    }
}