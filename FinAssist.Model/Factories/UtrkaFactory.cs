using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklizam.Model.Factories
{
    public class UtrkaFactory
    {
        public static Utrka CreateUtrka(string type, int id, float duljina, TimeSpan trajanje, DateTime datum) {
            switch (type)
            {
                case "Cestovna utrka":
                    return new CestovnaUtrka(id, duljina, trajanje, datum);
                case "Kronometar":
                    return new Kronometar(id, duljina, trajanje, datum);
                case "Kriterij":
                    return new Kriterij(id, duljina, trajanje, datum);
            }

            return null;
        }

        public static List<string> GetUtrkaTypes()
        {
            return new List<string> { "Cestovna utrka", "Kriterij", "Kronometar" };
        }
    }
}
