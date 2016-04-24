using System;
using _07CreateNamespaces.MyNamespaces;

namespace _07CreateNamespaces
{
    class CreateNamespaces
    {
        static void Main()
        {
            Cat[] cats = new Cat[10];

            for (int i = 0; i < cats.Length; i++)
            {
                cats[i] = new Cat(string.Format("Cat{0}",Sequence.NextValue()),"blue");
                cats[i].SayMiau();
            }
        }
    }
}
