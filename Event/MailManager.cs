using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class MailManager
    {
        public event EventHandler<NewMailEventArgs> NewMail;

        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            NewMail?.Invoke(this,e);
        }

        public void SimulateNewMail(string from, string to, string subject)
        {
            // проверка входных данных
            // создать обьект для хранениния информациию,
            // которую нужно передать получателям уведомления

            var e = new NewMailEventArgs(from, to, subject);
            // вызвать виртуальный метод,уведомляющий обьект о событии 
            // если ни один из производных типопв не переопределяет метод,
            // обьект уведомит всех получателей уведомления

            OnNewMail(e);
        }
    }
}
