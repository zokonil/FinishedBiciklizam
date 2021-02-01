using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.Model
{
    public class Statistike
    {
        public static int brojBiciklista(Utrka utrka)
        {
            return utrka._listRezultat.Count();
        }
        public static int brojPris(Utrka utrka)
        {
            int sum = 0;
            for(int i =0; i<utrka._listRezultat.Count();i++)
            {
                if (utrka._listRezultat[i].UkupnaUdaljenost != 0)
                {
                    sum++;
                }
            }
            return sum;
        }
        public static float prosjecnaUdaljenost(Utrka utrka)
        {
            float total=0;
            int brojPris = 0;
            for (int i = 0; i < utrka._listRezultat.Count(); i++)
            {
                if (utrka._listRezultat[i].UkupnaUdaljenost != 0)
                {
                    total += utrka._listRezultat[i].UkupnaUdaljenost;
                    brojPris++;
                }
            }
            if(brojPris==0)
            {
                return 0;
            }
            return total / brojPris; 
        }
        public static float prosjecnaBrzina(Utrka utrka)
        {
            float total = 0;
            int brojPris = 0;
            for (int i = 0; i < utrka._listRezultat.Count(); i++)
            {
                if (utrka._listRezultat[i].UkupnaUdaljenost != 0)
                {
                    float vrijeme = (float)utrka._listRezultat[i].Vrijeme.TotalMinutes / 60;
                    total += utrka._listRezultat[i].UkupnaUdaljenost/vrijeme;
                    brojPris++;
                }
            }
            if (brojPris == 0)
            {
                return 0;
            }
            return total / brojPris;
        }
        public static int getBiciklistBrojUtrka(Biciklist biciklist, List<Utrka> listUtrka)
        {
            int sum = 0;
            for(int i =0;i<listUtrka.Count();i++)
            {
                for (int j = 0; j < listUtrka[i]._listRezultat.Count(); j++) {
                    if(listUtrka[i]._listRezultat[i].Biciklist.Id==biciklist.Id)
                    {
                        sum++;
                        break;
                    }
                }
            }
            return sum;
        }
        public static float getBiciklistProsjecnoMjesto(Biciklist biciklist, List<Utrka> listUtrka)
        {
            int total = 0,sum = 0;
            for (int i = 0; i < listUtrka.Count(); i++)
            {
                for (int j = 0; j < listUtrka[i]._listRezultat.Count(); j++)
                {
                    if (listUtrka[i]._listRezultat[i].Biciklist.Id == biciklist.Id)
                    {
                        sum++;
                        total += listUtrka[i]._listRezultat[i].Mjesto;
                        break;
                    }
                }
            }
            if(sum==0)
            {
                return 0;
            }
            return (float)total/sum;
        }
        public static float getBiciklistProsjecnaBrzina(Biciklist biciklist, List<Utrka> listUtrka)
        {
            int sum = 0;
            float total = 0;
            for (int i = 0; i < listUtrka.Count(); i++)
            {
                for (int j = 0; j < listUtrka[i]._listRezultat.Count(); j++)
                {
                    if (listUtrka[i]._listRezultat[i].Biciklist.Id == biciklist.Id)
                    {
                        float vrijeme = (float)listUtrka[i]._listRezultat[i].Vrijeme.TotalMinutes / 60;
                        sum++;
                        total += listUtrka[i]._listRezultat[i].UkupnaUdaljenost/vrijeme;
                        break;
                    }
                }
            }
            if (sum == 0)
            {
                return 0;
            }
            return total / sum;
        }
    }
}
