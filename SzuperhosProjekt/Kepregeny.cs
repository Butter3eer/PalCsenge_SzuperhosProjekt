using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();

        public static void Szereplok(string fajlUtvonal)
        {
            using (StreamReader fajl = new StreamReader(fajlUtvonal))
            {
                while (!fajl.EndOfStream)
                {
                    string[] reszek = fajl.ReadLine()!.Split(' ');
                    if (reszek[0] == "Vasember")
                    {
                        Vasember vas = new Vasember();

                        for (int i = 0; i < int.Parse(reszek[1]); i++)
                        {
                            vas.KutyutKeszit();
                        }

                        szuperhosok.Add(vas);
                    }
                    else if (reszek[0] == "Batman")
                    {
                        Batman bat = new Batman();

                        for (int i = 0; i < int.Parse(reszek[1]); i++)
                        {
                            bat.KutyutKeszit();
                        }

                        szuperhosok.Add(bat);
                    }
                }

                fajl.Close();
            }
        }

        public static void Szuperhosok()
        {
            foreach (var item in szuperhosok)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
