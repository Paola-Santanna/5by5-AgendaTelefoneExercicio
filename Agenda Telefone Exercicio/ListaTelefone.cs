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
        List<string> listaTelefones;
        Endereco endereco;

        #region MetodoConstrutor
        public ListaTelefone(string nome)
        {
            this.nome = nome;
            this.telefone = " ";
            this.endereco = null;
            this.listaTelefones = new List<string>();
        }
        #endregion

        #region GetSetAtrubutos
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
        #endregion

        #region ReceberEndereco
        public Endereco ReceberEndereco()
        {
            string rua, numCasa, bairro, cidadeEstadoPais;

            Console.WriteLine("Rua: ");
            rua = Console.ReadLine();
            Console.WriteLine("Número da casa: ");
            numCasa = Console.ReadLine();
            Console.WriteLine("Bairro: ");
            bairro = Console.ReadLine();
            Console.WriteLine("Cidade, Estado - País");
            Console.WriteLine("Sua resposta: ");
            cidadeEstadoPais = Console.ReadLine();

            Endereco endereco = new(rua,numCasa,bairro,cidadeEstadoPais);

            setEndereco(endereco);

            return this.endereco;
        }
        #endregion

        #region AddTelefoneLista
        public void AddTelefoneLista(string telefone)
        {
            this.listaTelefones.Add(telefone);
        }
        #endregion

        #region ToStringAtributos
        public override string? ToString()
        {
            Console.WriteLine();
            Console.WriteLine($"{this.nome} \n{this.endereco.ToString()} \nTelefones:");
            foreach (string tel in listaTelefones)
            {
                Console.WriteLine(tel);
            }

            return "";
        }
        #endregion
    }
}
