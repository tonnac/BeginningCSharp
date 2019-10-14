using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_new
{
    #region new Method
//     class Mammal
//     {
//         public void Move()
//         {
//             Console.WriteLine("이동한다");
//         }
//     }
// 
//     class Lion : Mammal
//     {
//         new public void Move()
//         {
//             Console.WriteLine("네발로 움직인다.");
//         }
//     }
// 
//     class Whale : Mammal
//     {
//         new public void Move()
//         {
//             Console.WriteLine("수영한다");
//         }
//     }
// 
//     class Human : Mammal
//     {
//         new public void Move()
//         {
//             Console.WriteLine("두발로 움직인다");
//         }
//     }
    #endregion

    #region override

    class Mammal
    {
        virtual public void Move()
        {
            Console.WriteLine("이동한다");
        }
    }

    class Lion : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("네발로 움직인다.");
        }
    }

    class Whale : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("수영한다");
        }
    }

    class Human : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("두발로 움직인다");
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.Move();
            Mammal one = lion;
            one.Move();

        }
    }
}
