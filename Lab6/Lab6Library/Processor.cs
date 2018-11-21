using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Library
{
    public class Processor
    {
        public string Family { get; private set; }
        public string Model { get; private set; }
        public string Socket { get; private set; }
        public string Cores { get; private set; }
        public bool HasMultiplier { get; private set; }

        public Processor(string family, string model, string socket, string cores)
        {
            this.Family = family;
            this.Model = model;
            this.Socket = socket;
            this.Cores = cores;
            this.HasMultiplier = Model.IndexOf('k') != -1 ? true : false;
        }
        private int freq;
        public int Freq
        {
            get { return freq; }
            set
            {
                if (value > 0 && value < 5000)
                {
                    freq = value;
                }
                else
                    throw new InvalidFreqException();
            }
        }

        public override string ToString()
        {
            string multiplier = HasMultiplier ? "Помножувач розблокований" + "\n" : "Помножувач заблоковано" + "\n";
            return "------------------------------------------------\n" +
            "Дані про процессор\n" +
            "------------------------------------------------\n" +
            "Процесор: " + Family + " " + Model + "\n" +
            "Socket: " + Socket + "\n" +
            "Кiлькiсть ядер: " + Cores + "\n" +
            "Внутрiшня тактова частота: " + Freq + "MHz\n" + multiplier +
            "Придбати: https://rozetka.com.ua/ua/search/?text=" + Model;
        }
    }
}
