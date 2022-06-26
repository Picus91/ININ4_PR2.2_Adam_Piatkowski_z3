using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NET_ININ4_PR2._2_z4
{
    internal class Model
    {
        public ObservableCollection<Film> ListaFilmów { get; } = new ObservableCollection<Film>();
        public Model()
        {
            ListaFilmów.Add(new Film() { Tytuł = "Harry Potter i Kamień Filozoficzny", Reżyser = "Chris Columbus", Studio = "Warner Bross", Nośnik = "cd", DataWydania = DateTime.Parse("4.11.2001") });
            ListaFilmów.Add(new Film() { Tytuł = "Skazani na Shawshank", Reżyser = "Frank Darabont", Studio = "Castle Rock Entertainment ", Nośnik = "cd", DataWydania = DateTime.Parse("10.09.1994")});
            ListaFilmów.Add(new Film() { Tytuł = "Ojciec Chrzestny", Reżyser = "Francis Ford Coppola", Studio = "Paramount Pictures Alfran Productions", Nośnik = "dvd", DataWydania = DateTime.Parse("15.03.1972") });
            ListaFilmów.Add(new Film() { Tytuł = "Lista Schindlera", Reżyser = "Steven Spielberg", Studio = "Universal Pictures", Nośnik = "dvd", DataWydania = DateTime.Parse("30.11.1993") });
            ListaFilmów.Add(new Film() { Tytuł = "Joker", Reżyser = "Todd Phillips", Studio = "Warner Bross", Nośnik = "cd", DataWydania = DateTime.Parse("31.08.2019") });
            ListaFilmów.Add(new Film() { Tytuł = "Człowiek z blizną", Reżyser = "Brian De Palma", Studio = "Universal Pictures", Nośnik = "dvd", DataWydania = DateTime.Parse("01.12.1983") });
            ListaFilmów.Add(new Film() { Tytuł = "Przełęcz Ocalonych", Reżyser = "Mel Gibson", Studio = "Cross Creek Pictures", Nośnik = "cd", DataWydania = DateTime.Parse("04.09.2016") });

        }

        internal Film NowyFilm()
        {
            Film nowyFilm = new Film();
            ListaFilmów.Add(nowyFilm);
            return nowyFilm;
        }
    }
}