using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    class HeroMemento
    {
        public int Ammunition { get; private set; }
        public int Health { get; private set; }
        public HeroMemento(int ammunition, int health)
        {
            Ammunition = ammunition;
            Health = health;
        }
    }
}
