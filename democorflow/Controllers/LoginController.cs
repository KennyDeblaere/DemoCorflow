using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace democorflow
{
    class LoginController
    {
        private string login, password;
        private List<Werknemer> werknemers;

        public LoginController(string login, string password)
        {
            this.login = login.Replace(" ", "");
            this.login = this.login.ToLower();
            this.password = password;
            werknemers = (List<Werknemer>)DependencyService.Get<IDataService>().LoadAll<Werknemer>();
        }

        public int FindUsernameId()
        {
            int id = -1;
            foreach (Werknemer w in werknemers)
            {
                if (login == w.voornaam.ToLower() + w.naam.ToLower() && password == w.passwoord)
                    id = w.medewerkerid;
            }
            return id;
        }
    }
}
