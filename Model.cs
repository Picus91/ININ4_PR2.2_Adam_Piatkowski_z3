using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NET_ININ4_PR2._2_z4
{
    internal class Model
    {
        public ObservableCollection<Osoba> ListaOsób { get; } = new ObservableCollection<Osoba>();
        public Model()
        {
            ListaOsób.Add(new Osoba() { Imię = "Adam", Nazwisko = "Wiśniewski" });
            ListaOsób.Add(new Osoba() { Imię = "Beata", Nazwisko = "Jabłońska" });
        }

        internal Osoba NowaOsoba()
        {
            Osoba nowa = new Osoba();
            ListaOsób.Add(nowa);
            return nowa;
        }
    }
}