using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Внимание: cообщения в общем чате сохраняются");
            var chatRoom = new ChatRoom();

            var ivan = new Participant(chatRoom, "Ivan");
            var tanya = new Participant(chatRoom, "T@ne4ka");
            var jan = new Participant(chatRoom, "JAN");
            var andrey = new Participant(chatRoom, "An");
            var diana = new Participant(chatRoom, "Dayan");

            ivan.SendMessage("Привет, идем в кино?");
            tanya.SendMessage("Я сегодня не могу");
            ivan.SendMessage("Ян,Андрей, Диана, а вы?");
            jan.SendMessage("Ок, давай на 'Последствия'...");
            andrey.SendMessage("Ок, пойду");
            diana.SendMessage("Нет, не могу");
            ivan.SendMessage("Хорошо, я куплю 3 билета.");
            Console.WriteLine("__________________________________________________________________");
           
            Console.WriteLine();
            Console.WriteLine("Press Enter");
            Console.WriteLine();
            Console.ReadKey();
            var cinemaGroup = new Group();

            ivan = new Participant(cinemaGroup, "Ivan");
            andrey = new Participant(cinemaGroup, "An");
            jan = new Participant(cinemaGroup, "JAN");

            ivan.SendMessageGroup("Встречаемся возле 'Беларуси' в 18:50.");
            andrey.SendMessageGroup("Я на месте");
            jan.SendMessageGroup("У меня форс-мажор, простите, не смогу");
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Press Enter");
            Console.WriteLine();
            Console.ReadKey();
            var message = new Message();
            ivan = new Participant(message, "Ivan");
            andrey = new Participant(message, "An");
            ivan.Send("Андрей, заходи внутрь я сижу в кафетерии");
            andrey.Send("Вижу тебя");
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Press Enter");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
