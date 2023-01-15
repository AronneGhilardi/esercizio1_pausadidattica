using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace esercizio1_pausadidattica
{
    public class Telefono
    {
        private string _id;
        private string _produttore;
        private string _modello;
        private double _credito;
        private double _creditomin;
        private string[] _listanera;

        public Telefono(string id, string produttore, string modello, double credito, double creditomin)
        {
            Id = id;
            Produttore = produttore;
            Modello = modello;
            CreditoMin = creditomin;
            Credito = credito;
            _listanera = new string[50];
        }

        public Telefono(string id, string modello, double credito, double creditomin) : this(id, "NA", modello, credito, creditomin)
        {

        }

        public Telefono(string id, double credito, double creditomin) : this(id, "NA", "NA", credito, creditomin)
        {

        }

        public Telefono(string id) : this(id, "NA", "NA", 0, 0)
        {

        }

        public Telefono() : this("NA", "NA", "NA", 0, 0)
        {

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
                if ( value > CreditoMin)
                {
                    _credito = value;
                }
                else
                {
                    throw new Exception("Credito minimo raggiunto!");
                }
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
                _creditomin = value;
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

        public void Avviare(string nr)
        {
            if (Credito >= CreditoMin)
            {
                Digitare(nr);
                switch(Comporre(nr))
                {
                    case 1:
                        Credito = Credito -1;
                        break;

                    case 2:
                        Credito = Credito - 10;
                        break;

                    case 3:
                        throw new Exception("Numero invalido!");
                }
            }
            else
            {
                throw new Exception("Credito insufficente!");
            }
        }

        public void Digitare(string nr)
        {
            string pattern = @"[0-9+#*]*";
            if (!Regex.IsMatch(nr, pattern))
            {
                throw new Exception("Errore nella digitazione del numero di telfono!");
            }
        }

        public int Comporre(string nr)
        {
            string nazionale = @"^[0-9]{3,4}[0-9]{7,9}$";
            string internazionale = @"^\+[0-9]{2}[0-9]{3,4}[0-9]{7,9}$";
            if (Regex.IsMatch(nr,nazionale))
            {
                return 1; //NAZIONALE
            }
            else if (Regex.IsMatch(nr, internazionale))
            {
                return 2; //INTERNAZIONALE
            }
            else 
            {
                return 3; //NON VALIDO
            }
        }

        int counter = 0;

        public void AggiungereNero(string nr)
        {
            Digitare(nr);
            _listanera[counter] = nr;
            counter++;

        }

        public void EliminareNero(string  nr)
        {
            int pos = -1;

            for (int i = 0; i < 50; i++)
            {
                if (_listanera[i] == nr)
                {
                    pos = i;
                    break;
                }
            }

            if (pos != -1)
            {
                _listanera[pos] = null;
            } 
            else
            {
                throw new Exception("Non trovato");
            }   
        }

        public string[] VisualizzareNero()
        {
            return _listanera;
        }

        public override string ToString()
        {
            return this.Id + ";" + this.Produttore + ";" + this.Modello + ";" + this.Credito + ";" + this.CreditoMin;
        }

        public bool Equals(Telefono x)
        {
            if (x == null)
            {
                return false;
            }
            if (this == x)
            {
                return true;
            }

            return (this.Id == x.Id);
        }

        public Telefono Clone()
        {
            return new Telefono(this);
        }

        protected Telefono(Telefono other) : this(other.Id, other.Produttore, other.Modello, other.Credito, other.CreditoMin)
        {

        }
    }
}
