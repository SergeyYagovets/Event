using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            var mailManager = new MailManager();
            mailManager.NewMail += MailManagerNewMail;
            var sms = new SMS(mailManager);
            
            Console.Write("Введите ваше имя:");
            var sender = Console.ReadLine();

            Console.Write("С кем вы хотите связаться?");
            var target = Console.ReadLine();

            Console.Write("Напишите ваше сообщение:");
            var message = Console.ReadLine();
            mailManager.SimulateNewMail(sender, target, message);
            Console.ReadLine();
        }

        private static void MailManagerNewMail(object sender, NewMailEventArgs e)
        {
            
        }
    }
}
