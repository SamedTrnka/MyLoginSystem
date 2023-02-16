using System;
using System.Collections.Generic;
using System.Text;

namespace MyLoginSystem
{
    class Benutzer
    {
        public String vorname;
        public String nachname;
        public String benutzername;
        public String email;
        public String passwort;

        public Benutzer(String datensatz)
        {
            String[] subString= datensatz.Split(',');

            vorname = subString[0];
            nachname = subString[1];
            benutzername = subString[2];
            email = subString[3];
            passwort = subString[4];
        }
    }
}
