using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    class Guiches
    {
        private List<Guiche> listaGuiches;

        public Guiches()
        {
            List<Guiches> listaGuiches = new List<Guiches>;
        }

        public void Adicionar(Guiche guiche)
        {
            listaGuiches.Add(guiche);
        }
    }
}
