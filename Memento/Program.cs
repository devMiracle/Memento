using Memento.Hero;
using Memento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero1 hero = new Hero1();
            GameHistory history = new GameHistory();
            hero.Shot();

            history.History.Push(hero.SaveState());


            for (int i = 0; i < 3; i++)
                hero.Shot();

            hero.RestoreState(history.History.Pop());

            for (int i = 0; i < 3; i++)
                hero.Shot();






            Console.ReadKey(true);
        }
    }
}
