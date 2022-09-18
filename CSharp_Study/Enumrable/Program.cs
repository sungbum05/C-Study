using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumrable
{
    [Monster("Sungbum", 10)]
    internal class Program
    {
        static void Main(string[] args)
        {
            MonsterAttribute monsterAttribute = new MonsterAttribute("asd",123);
            Console.WriteLine(monsterAttribute.Name);
        }
    }

    class MonsterAttribute : System.Attribute
    {
        public string Name;
        public int Power;

        public MonsterAttribute(string Name, int Power)
        {
            this.Name = Name;
            this.Power = Power;
        }
    }

    public interface IEnumerator
    {
        object Current { get; }
        bool MoveNext();
        void Reset();
    }
}
