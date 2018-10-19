using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public Guiche()
        {
            this.atendimentos = new Queue<Senha>;
            this.id = 0;

        }

        public Guiche(int id)
        {

        }

        public bool chamar(Queue<Senha> filaSenhas)
        {

            return true;
        }
    }
}
