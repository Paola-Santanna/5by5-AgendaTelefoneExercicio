using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefone_Exercicio
{
    internal class ListaControleObjeto
    {
        ListaTelefone tail;
        ListaTelefone head;

        public ListaControleObjeto()
        {
            /*
             * Para o começo das operações com a estrutura de dados em lista,
             * o começo "head" e o final "tail" devem ter valores nulos.
             * São eles, com mais duas variáveis do tipo objeto, que vão
             * controlar a ordem de inserção e retirada dos contatos de telefone.
             */
            this.tail = null;
            this.head = null;
        }


    }
}
