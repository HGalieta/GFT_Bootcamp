using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFT_RPG.Entities
{
    internal class Knight : Hero
    {
        public Knight(string name, int level)
            : base(name, level)
        {
        }

        public override string Attack()
        {
            Random bonus = new Random();
            int valorBonus = bonus.Next(0, 10);

            if (valorBonus > 5)
            {
                return $"{this.Name} ataca com sua espada causando um DANO CRITICO!";
            }
            else
            {
                return $"{this.Name} ataca com sua espada.";
            }
        }
    }
}
