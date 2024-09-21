using System;
using System.Threading.Tasks;

namespace Iscluchenyaa
{

    class Programm
    {

        public static void Main(string[] args)
        {
            //Начало задания 1

            Task1.TaskExceptions();
            Console.WriteLine();

            //Конец задания 1

            //Начало задания 2

            SortClass sortLnames = new SortClass();
            sortLnames.SortEvent += ShowList.Show;
            try
            {
                sortLnames.ReadSortType();
            }
            catch (MyExcep ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //Конец задания 2


        }

    }
}