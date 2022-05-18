using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFT_RPG.Entities
{
    internal abstract class Hero
    {
        public Hero(string name, int level)
        {
            Name = name;
            Level = level;
            HP = 100 * level;
            MP = 50 * level;
        }

        public string Name { get; set; }
        public string HeroClass { get; private set; }
        public int Level { get; private set; }
        public int HP { get; private set; }
        public int MP { get; private set; }

        public override string ToString()
        {
            return $"Nome: {this.Name}, Level: {this.Level}, HP: {this.HP}, MP: {this.MP}";
        }

        public abstract string Attack();
    }
}
