using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    public class Opponent
    {
        public string OpponentName { get; set; }
        public int OpponentDamage { get; set; }

        public Opponent(string opponentName, int opponentDamage)
        {
            OpponentName = opponentName;
            OpponentDamage = opponentDamage;
        }
    }
}
