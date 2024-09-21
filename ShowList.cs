using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iscluchenyaa
{
    static class ShowList
    {
        internal static void Show(int sort)
        {
            List<string> LNames = ListOfPeople.NewList();
            switch (sort)
            {
                case 1:
                    {
                        LNames.Sort();
                        foreach (string lname in LNames)
                        {
                            Console.WriteLine(lname);
                        }
                        break;
                    }
                case 2:
                    {
                        LNames.Sort();
                        LNames.Reverse();
                        foreach (string lname in LNames)
                            Console.WriteLine(lname);
                        break;
                    }
            }

        }
    }
}
