using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    class Senha
    {
        private int id;
        private DateTime dataGerac, horaGerac, dataAtend, horaAtend;

        public Senha(int id) {
            this.id = id;
            this.dataGerac = DateTime.Today;
            this.horaGerac = Convert.ToDateTime(DateTime.Now.TimeOfDay);
        }

        public string dadosParciais()
        {
            return (id + ”-“ +this.dataGerac + ”-“ + this.horaGerac).toString ;
        }

        public string dadosCompletos()
        {
            return Console.WriteLine(id + ”-“ + DataGerac + ”-“ +HoraGerac + ”-“ +DataAtend + ”-“ +HoraAtend);
        }
    }
}
