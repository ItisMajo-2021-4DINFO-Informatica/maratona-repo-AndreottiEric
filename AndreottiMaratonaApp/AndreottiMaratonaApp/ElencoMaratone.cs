using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AndreottiMaratonaApp
{
    class ElencoMaratone
    {
        public List<Maratona> Elenco { get; set; }

        public ElencoMaratone()
        {
            Elenco = new List<Maratona>();
        }

        public void AggiungiMaratona(Maratona maratona)
        {
            Elenco.Add(maratona);
        }

        public int TrasformaTempo(string oreMinuti)
        {
            int ore = int.Parse(oreMinuti.Substring(0, 2));
            int minuti = int.Parse(oreMinuti.Substring(3, 2));
            return ore * 60 + minuti;
        }


        public void LeggiDaFile()
        {
            FileStream flussodati = new FileStream("maratona.txt", FileMode.Open, FileAccess.Read);
            StreamReader readerDati = new StreamReader(flussodati);

            while(!readerDati.EndOfStream)
            {
                string riga = readerDati.ReadLine();
                // Rossi Fabio % Fiamme Blu % 2h18m % Torino
                string[] campi = riga.Split('%');

                Maratona maratona = new Maratona();
                maratona.NomeAtleta = campi[0];
                maratona.Società = campi[1];
                maratona.TempoInMinuti = TrasformaTempo(campi[2]);
                maratona.Città = campi[3];

                AggiungiMaratona(maratona);
            }
        }


        internal void EliminaConCodice(int rowIndex)
        {
            Elenco.RemoveAt(rowIndex);
        }
    }
}
