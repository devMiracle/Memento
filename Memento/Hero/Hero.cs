using Memento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Hero
{
    class Hero1
    {
        private int Ammunition { get; set; }
        private int Health { get; set; }
        public Hero1()
        {
            Ammunition = 10;
            Health = 100;
        }
        public void Shot()
        {
            if (Ammunition > 0)
            {
                Ammunition--;
                Console.WriteLine("Произведен выстрел, патронов осталось: {0}", Ammunition);
            }
            else
                Console.WriteLine("Патронов больше нет: {0}", Ammunition);
        }
        //сохранение состояния
        public HeroMemento SaveState()
        {
            Console.WriteLine("Сохранение игры. Параметры: {0} патронов, {1} жизней", Ammunition, Health);
            return new HeroMemento(Ammunition, Health);
        }
        //востановление состояния
        public void RestoreState(HeroMemento memento)
        {
            Ammunition = memento.Ammunition;
            Health = memento.Health;
            Console.WriteLine("Восстановление игры. Параметры: {0} патронов, {1} жизней", Ammunition, Health);
        }
    }
}
