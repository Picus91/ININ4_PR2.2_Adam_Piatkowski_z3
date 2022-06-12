using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NET_ININ4_PR2._2_z4
{
    public class Osoba : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        static readonly Dictionary<string, string[]> PowiązaneWłaściwości
            = new Dictionary<string, string[]>()
            {
                ["Imię"] = new string[] {"ImięNazwisko"},
                ["Nazwisko"] = new string[] {"ImięNazwisko"},
                ["DataUrodzenia"] = new string[] {"Wiek"},
                ["DataŚmierci"] = new string[] {"Wiek"},
                ["ImięNazwisko"] = new string[] {"SkrótInformacji"},
                ["Wiek"] = new string[] {"SkrótInformacji"}
            };
        void OnPropertyChanged(
            [CallerMemberName] string właściwość = null,
            HashSet<string> obsłużoneWcześniej = null
            )
        {
            if (obsłużoneWcześniej == null)
                obsłużoneWcześniej = new HashSet<string>();
            if(!obsłużoneWcześniej.Contains(właściwość))
            {
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(właściwość));
                obsłużoneWcześniej.Add(właściwość);
                if (PowiązaneWłaściwości.ContainsKey(właściwość))
                    foreach (string powiązanaWłaściwość in PowiązaneWłaściwości[właściwość])
                        OnPropertyChanged(powiązanaWłaściwość, obsłużoneWcześniej);
            }
        }

        private string
            imię,
            nazwisko
            ;
        private DateTime?
            dataUrodzenia,
            dataŚmierci
            ;

        public string Imię {
            get => imię;
            set {
                imię = value;
                OnPropertyChanged();
            }
        }
        public string Nazwisko {
            get => nazwisko;
            set
            {
                nazwisko = value;
                OnPropertyChanged();
            }
        }
        public string ImięNazwisko => $"{Imię} {Nazwisko}";

        public DateTime? DataUrodzenia {
            get => dataUrodzenia;
            set {
                dataUrodzenia = value;
                OnPropertyChanged();
            }
        }
        public DateTime? DataŚmierci {
            get => dataŚmierci;
            set {
                dataŚmierci = value;
                OnPropertyChanged();
            }
        }
        public string Wiek {
            get {
                if (dataUrodzenia == null)
                    return "BD";
                DateTime? koniec;
                if (dataŚmierci == null)
                    koniec = DateTime.Now;
                else
                    koniec = dataŚmierci;

                TimeSpan przedział = (TimeSpan)(koniec - dataUrodzenia);
                int lata = (int)(przedział.Days / 365.25);
                return lata.ToString();
            }
        }
        public string SkrótInformacji
        {
            get => $"{ImięNazwisko}, {Wiek} lat(a)";
        }

        /*public override string ToString()
{
return $"{Imię} {Nazwisko}";
}*/
    }
}