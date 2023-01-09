using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio1_pausadidattica
{
    public class Telefono
    {
        private string _id;
        private string _produttore;
        private string _modello;
        private double _credito;
        private double _creditomin;

        public Telefono(string id, string produttore, string modello, double credito, double creditomin)
        {
            Id = id;
            Produttore = produttore;
            Modello = modello;
            Credito = credito;
            CreditoMin = creditomin;
        }

        public string Id
        {
            set
            {
                if (value != null)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _id;
            }
        }

        public string Produttore
        {
            set
            {
                if (value != null)
                {
                    _produttore = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _produttore;
            }
        }

        public string Modello
        {
            set
            {
                if (value != null)
                {
                    _modello = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _modello;
            }
        }

        public double Credito
        {
            set
            {
                _credito = value;
            }
            get
            {
                return _credito;
            }
        }

        public double CreditoMin
        {
            set
            {
                if (value >= -10)
                {
                    _creditomin = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _creditomin;
            }
        }

        public void Ricaricare(int euro)
        {
            if (euro > 0)
            {
                Credito = Credito + euro;
            }
            else
            {
                throw new Exception("Non puoi aggiungere una quantità negativa!");
            }
        }

        public void Avviare()
        {
            if (Credito >= 0)
            {
                Digitare();
            }
            else
            {
                throw new Exception("Credito insufficente!");
            }
        }

        public void Digitare()
        {

        }


    }

    
}
