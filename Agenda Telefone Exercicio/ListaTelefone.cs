using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefone_Exercicio
{
    internal class ListaTelefone
    {
        string nome;
        string telefone;
        Endereco endereco;

        public ListaTelefone(string nome, string telefone, Endereco endereco)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        public string getNomePessoa() { return this.nome; } //Retorna o nome da pessoa
        public void setNomePessoa(string nomePessoa) //Atribuir o nome que o usuário digitou ao atibuto nome
        {
            this.nome = nomePessoa;
        }
        public string getTelefone() {  return this.telefone; } //Retorna o telefone
        public void setTelefone(string telefone) //Atribuir a string digitada pelo usuário à propriedade telefone
        {
            this.telefone = telefone;
        }
        public Endereco getEndereco() {  return this.endereco; } //Retorna o endereço e seus atributos
        public void setEndereco(Endereco endereco) //Atribuir valor objeto ao this.endereco
        {
            this.endereco = endereco;
        }
    }
}
