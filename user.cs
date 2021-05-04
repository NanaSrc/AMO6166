using System;
using System.Collections.Generic;
using System.Text;

namespace marco
{
    class user
    {
        private string nome;
        private string key;
        private bool ama = false;
        private bool nomec = false;
        private bool keyc = false;


        public string Nome { get => nome; set => nome = value; }
        public string Key { get => key; set => key = value; }
        public bool Ama { get => ama; set => ama = value; }
        public bool Nomec { get => nomec; set => nomec = value; }
        public bool Keyc { get => keyc; set => keyc = value; }

        public user(string nome, string key, bool ama, bool nomec, bool keyc)
        {
            this.nome = nome;
            this.key = key;
            this.ama = ama;
            this.nomec = nomec;
            this.keyc = keyc;
        }

        public user()
        {
            this.nome = "";
            this.key = "";
            this.ama = false;
            this.nomec = false;
            this.keyc = false;
        }
    }
}
