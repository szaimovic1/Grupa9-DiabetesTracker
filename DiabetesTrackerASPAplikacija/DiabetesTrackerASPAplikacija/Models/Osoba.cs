﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class Osoba:INotifyPropertyChanged, INotifyDataErrorInfo
    {
        int id;
        String ime;
        String prezime;
        String username;
        String password;
        String potvrdaPassworda;
        String eMail;
        Spol spol;
        String JMBG;
        DateTime datumRodjenja;

        public int Id { get => id; set => id = value; }
        public virtual Spol Spol { get => spol; set => spol = value; }


        /*public virtual string JMBG1
        {
            get => JMBG;

            set
            {
                if (value.Length != 13)
                {
                    throw new Exception("Matično broj mora imati 13 karaktera");
                }

                else if (value.Length == 13)
                {
                    string datum = DatumRodjenja.ToString();
                    string maticni = value;
                     string maticni1 = "" + maticni[2] + maticni[3]+maticni[0]+maticni[1];
                    for(int i = 4; i < maticni.Length; i++)
                    {
                        maticni1 += maticni[i];
                    }
                    


                    int b = 0;
                    for (int i = 0; i < 7; i++)
                    {
                        if (datum[i + b] == '/') b++;
                        if (i == 4) b++;
                        if (datum[i + b] != maticni1[i])
                        {
                            throw new Exception("Neispravan JMBG");
                        }
                    }

                }
                JMBG = value;
            }
        }


        public virtual string JMBG2
        {
            get => JMBG;

            set
            {                
                JMBG = value;
            }
        }

        public string Ime
        {
            get => ime;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Ime ne smije biti prazno");
                if (value.Any(c => !char.IsLetter(c)))
                    throw new Exception("Ime ne smije sadržavati ništa osim slova");
                if (value.Substring(1, value.Length - 1).Any(c => char.IsUpper(c)))
                    throw new Exception("Samo prvo slovo imena može biti veliko");
                if (!char.IsUpper(value[0]))
                    throw new Exception("Prvo slovo imena mora biti veliko");
                ime = value;
            }
        }
        public string Prezime
        {
            get => prezime;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Prezime ne smije biti prazno");
                if (value.Any(c => !char.IsLetter(c)))
                    throw new Exception("Prezime ne smije sadržavati ništa osim slova");
                if (value.Substring(1, value.Length - 1).Any(c => char.IsUpper(c)))
                    throw new Exception("Samo prvo slovo prezimena može biti veliko");
                if (!char.IsUpper(value[0]))
                    throw new Exception("Prvo slovo prezimena mora biti veliko");
                prezime = value;
            }
        }
        public string Username
        {
            get => username;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Username ne smije biti prazno");
                username = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Password ne smije biti prazan");
                password = value;
            }
        }
        public string EMail
        {
            get => eMail;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !System.Text.RegularExpressions.Regex.IsMatch(value, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                     @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                     @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                    throw new Exception("Email nevalidan");
                eMail = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get => datumRodjenja;
            set
            {
                if (value < DateTime.Now)
                    datumRodjenja = value;
                else throw new Exception("Datum rođenja nevalidan");
            }
        }

        public string PotvrdaPassworda {
            get => potvrdaPassworda;
            set
            {
                if(value != Password)
                    throw new Exception("Potvrda passworda se ne poklapa sa passwordom");
                potvrdaPassworda = value;
            }
        }

    */

        [Required]
        public string Ime { get => ime; set => ime = value; }
        [Required]
        public string Prezime { get => prezime; set => prezime = value; }
        [Required]
        public string Username { get => username; set => username = value; }
        [Required]
        public string Password { get => password; set => password = value; }
        [Required]
        public string PotvrdaPassworda { get => potvrdaPassworda; set => potvrdaPassworda = value; }
        [Required]
        [DisplayName("eMail")]
        public string EMail { get => eMail; set => eMail = value; }
        [Required]
        [DisplayName("JMBG")]
        [StringLength(13,MinimumLength =13,ErrorMessage ="JMBG mora imati tacno 13 karaktera")]
        public string JMBG1 { get => JMBG; set => JMBG = value; }
        [Required]
        [DisplayName("Spol")]
        public Spol Spol1 { get => spol; set => spol = value; }
        [Required]
        [DisplayName("Datum rodjenja")]
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }

        //koristenje interfejsa INotifyDataErrorInfo


        public bool HasErrors
        {
            get { return (this._errors.Count > 0); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        private Dictionary<string, List<String>> _errors = new Dictionary<string, List<string>>();

        public bool IsValid
        {
            get { return !this.HasErrors; }

        }

        

        public void AddError(string propertyName, string error)
        {
            // Add error to list
            this._errors[propertyName] = new List<string>() { error };
            this.NotifyErrorsChanged(propertyName);
        }

        public void RemoveError(string propertyName)
        {
            // remove error
            if (this._errors.ContainsKey(propertyName))
                this._errors.Remove(propertyName);
            this.NotifyErrorsChanged(propertyName);
        }

        public void NotifyErrorsChanged(string propertyName)
        {
            // Notify
            if (this.ErrorsChanged != null)
                this.ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        public IEnumerable GetErrors(string propertyName)
        {
            if (this._errors.ContainsKey(propertyName))
                return this._errors[propertyName];
            return null;
        }
    }
}