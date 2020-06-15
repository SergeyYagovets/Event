using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class SMS
    {
        public SMS(MailManager mm)
        {
            mm.NewMail += Mm_NewMail;
        }

        private void Mm_NewMail(object sender, NewMailEventArgs e)
        {
            Console.WriteLine($"{sender} {e}");
        }

        public void Send(string message)
        {
            Console.WriteLine($"Отпровляем SMS сообщение:   {message}");
        }
    }
}
