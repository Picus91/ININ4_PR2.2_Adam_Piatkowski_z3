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

        private string imię;
        private string nazwisko;

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

        /*public override string ToString()
{
return $"{Imię} {Nazwisko}";
}*/
    }
}