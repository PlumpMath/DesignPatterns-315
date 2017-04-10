using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component basePage = new BasePage("Охота и рыбалка", "Сайт для любителей рыбалки, охоты, подводной охоты");
           
            Component section = new Section("-Охота", "Особенности национальной охоты 2017");
            Component page = new EmptyPage("----Лицензия", "Правила получения лицензии");
            Component page2 = new EmptyPage("----Карта", "Карта миграции лисиц");

            section.Add(page);
            section.Add(page2);
           
            basePage.Add(section);
          //  basePage.Print();
            Console.WriteLine();

            Component section2 = new Section("-Подводная охота", "Особенности подводной охоты 2017");
            Component page3 = new EmptyPage("----Удостоверение охотника-рыболова", "Где можно получить документ, правила продления");
            Component page4 = new EmptyPage("----Снаряжение", "Где купить");
            section2.Add(page3);
            section2.Add(page4);

            basePage.Add(section2);
            basePage.Print();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Модератор забанил страницу: 'Удостоверение охотника - рыболова'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------");
            section2.Remove(page3);
            basePage.Print();
            Console.Read();
        }
    }
}
