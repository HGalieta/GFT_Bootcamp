using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFT_RPG.Entities
{
    internal class Mage : Hero
    {
        public Mage(string name, int level)
            : base(name, level)
        {
        }

        public override string Attack()
        {
            Random bonus = new Random();
            int valorBonus = bonus.Next(0, 10);

            if (valorBonus > 5)
            {
                return $"{this.Name} lança uma magia causando um DANO CRITICO!";
            }
            else
            {
                return $"{this.Name} lança uma magia.";
            }
        }
    }
}
