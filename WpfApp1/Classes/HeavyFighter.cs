using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    public class HeavyFighter : Fighter
    {
        public HeavyFighter(string fighterName, int healthMax)
            : base(fighterName, healthMax) { }

        public override void ApplyDamage(int damageAmount)
        {
            int realDamage = (int)(damageAmount * 0.75);
            base.ApplyDamage(realDamage);
        }
    }
}
