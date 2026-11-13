using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    public class Fighter
    {
        public string FighterName { get; set; }
        public int HealthMax { get; set; }
        public int HealthCurrent { get; set; }

        public Fighter(string fighterName, int healthMax)
        {
            FighterName = fighterName;
            HealthMax = healthMax;
            HealthCurrent = healthMax;
        }
        public virtual void ApplyDamage(int damageAmount)
        {
            HealthCurrent -= damageAmount;
            if (HealthCurrent < 0)
                HealthCurrent = 0;
        }
    }
}

