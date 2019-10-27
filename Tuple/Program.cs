using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class IntResult
    {
        public bool Parsed { get; set; }
        public int Number { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Program pg = new Program();
            //여러 값을 반환받을때마다 클래스 만들어야되네 ㅠㅠ
            IntResult result = pg.ParseInteger("15");

            Console.WriteLine(result.Parsed);
            Console.WriteLine(result.Number);

            //Dynamic써볼까 근데 런타임에 문제 생길거 같은데 ㅠㅠ
            dynamic _result = _ParseInteger("20");
            Console.WriteLine(_result.Parsed);
            Console.WriteLine(_result.Number);

            //그래서 나온게 Tuple~!
            Tuple<bool, int> __result = pg.__ParseInteger("30");
            Console.WriteLine(__result.Item1);
            Console.WriteLine(__result.Item2);

            //함수에서 정의한 이름으로 쓰려면 var로 받으면 된다
            var result_ = pg.ParseInteger_("40");
            bool ar = result_.Parsed;
            int nr = result_.Number;
        }

        private IntResult ParseInteger(string text)
        {
            IntResult result = new IntResult();

            try
            {
                result.Number = Int32.Parse(text);
                result.Parsed = true;
            }
            catch
            {
                result.Parsed = false;
            }

            return result;
        }

        private static dynamic _ParseInteger(string text)
        {
            int number = 0;

            try
            {
                number = Int32.Parse(text);
                return new { Number = number, Parsed = true };
            }
            catch
            {
                return new { Number = number, Parsed = true };
            }
        }

        private Tuple<bool, int> __ParseInteger(string text)
        {
            int number = 0;
            bool result = false;

            try
            {
                number = Int32.Parse(text);
                result = true;
            }
            catch { }
            return new Tuple<bool, int>(result, number);
        }

        private (bool Parsed, int Number) ParseInteger_(string text)
        {
            int number = 0;
            bool result = false;

            try
            {
                number = Int32.Parse(text);
                result = true;
            }
            catch { }
            return (result, number);
        }
    }
}