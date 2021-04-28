using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Pool_Puzzle_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            Nose[] i = new Nose[3];
            i[0] = new Acts();
            i[1] = new Clowns();
            i[2] = new Of76();
            for (int x = 0; x < 3; x++)
            {
                result += (i[x].Ear() + " " + i[x].Face) + "\n";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    interface Nose
    {
        int Ear();
        string Face { get; }
    }

    abstract class Picasso : Nose
    {
        public Picasso(string face)
        {
            this.face = face;
        }
        string face;
        public virtual string Face
        {
            get { return face; }
        }
        public virtual int Ear()
        {
            return 7;
        }
    }

    class Clowns : Picasso
    {
        public Clowns() : base("Clowns") { }
    }

    class Acts : Picasso
    {
        public Acts() : base("Acts") { }
        public override int Ear()
        {
            return 5;
        }
    }

    class Of76 : Clowns
    {
        public override string Face
        {
            get { return "Of76"; }
        }
    }

}
