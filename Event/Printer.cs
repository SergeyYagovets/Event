using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Printer
    {
        public Printer(MailManager mailManager)
        {
            mailManager.NewMail += OnMailManagerNewMail;
        }

        private void OnMailManagerNewMail(object sender, NewMailEventArgs e)
        {
            Console.WriteLine("Получено новое сообщениеб.Выводим на печать:");
            Console.WriteLine($"Письмо от {e.From} для {e.To}.");
            Console.WriteLine(e.Subject);
            
        }

        private void Unregister(MailManager mailManager)
        {
            mailManager.NewMail -= OnMailManagerNewMail;
        }
    }
}
