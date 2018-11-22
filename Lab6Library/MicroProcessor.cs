using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Library
{
    public class MicroProcessor : Processor
    {
        public string Architecture { get; private set; }

        public MicroProcessor(string family, string model, string socket, string cores, string architecture) : base (family, model, socket, cores)
        {
            this.Architecture = architecture;
        }

        public override string ToString()
        {
            return "------------------------------------------------\n" +
            "Данi про мiкропроцессор\n" +
            "------------------------------------------------\n" +
            "Процесор: " + Family + " " + Model + "\n" +
            "Socket: " + Socket + "\n" +
            "Кiлькiсть ядер: " + Cores + "\n" +
            "Внутрiшня тактова частота: " + Freq + "MHz\n" +
            "Архiтектура: " + Architecture;

        }
    }
}
