using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NET_ININ4_PR2._2_z4
{
    public class Film : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        static readonly Dictionary<string, string[]> PowiązaneWłaściwości
            = new Dictionary<string, string[]>()
            {
                ["Tytuł"] = new string[] { "Tytuł" },
                ["Reżyser"] = new string[] { "Reżyser" },
                ["Studio"] = new string[] { "Studio" },
                ["Nośnik"] = new string[] { "Nośnik" },
                ["DataWydania"] = new string[] { "DataWydania" }
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
            tytuł,
            reżyser,
            studio,
            nośnik;

        private DateTime?
            dataWydania;

        public string Tytuł {
            get => tytuł;
            set {
                tytuł = value;
                OnPropertyChanged();
            }
        }
        public string Reżyser
        {
            get => reżyser;
            set
            {
                reżyser = value;
                OnPropertyChanged();
            }
        }
        public string Studio
        {
            get => studio;
            set
            {
                studio = value;
                OnPropertyChanged();
            }
        }
        public string Nośnik
        {
            get => nośnik;
            set
            {
                nośnik = value;
                OnPropertyChanged();
            }
        }

        public DateTime? DataWydania
        {
            get => dataWydania;
            set {
                dataWydania = value;
                OnPropertyChanged();
            }
        }

        public string SkrótInformacji
        {
            get => $"{Tytuł}.\nWyreżyserowany przez {Reżyser}.\nPremiere miał: {DataWydania.ToString("d")}";
        }
    }
}