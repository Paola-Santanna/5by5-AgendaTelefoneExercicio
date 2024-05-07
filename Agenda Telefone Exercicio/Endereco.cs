using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefone_Exercicio
{
    internal class Endereco
    {
        string nomeRua;
        string numCasa;
        string nomeBairro;
        string nomeCidadeEstadoPais;

        #region MetodoConstrutor
        public Endereco(string nomeRua, string numCasa, string nomeBairro, string nomeCidadeEstadoPais)
        {
            this.nomeRua = nomeRua;
            this.numCasa = numCasa;
            this.nomeBairro = nomeBairro;
            this.nomeCidadeEstadoPais = nomeCidadeEstadoPais;
        }
        #endregion

        #region GetSetAtributos
        public string getNomeRua() {  return nomeRua; } //Retornar o nome da rua
        public void setNomeRua(string rua) //Vai atribuir o nome da rua
        {
            this.nomeRua = rua;
        }
        public string getNumCasa() {  return numCasa; } //Retornar o número da casa
        public void setNumCasa(string numero) //Atribuir uma string no atributo numCasa
        {
            this.numCasa= numero;
        }
        public string getNomeBairro() {  return this.nomeBairro; } //Retornar o nome do bairro
        public void setNomeBairro(string nomeBairro) //Atribuir uma string ao nome do bairro
        {
            this.nomeBairro = nomeBairro;
        }
        public  string getNomeCidadeEstadoPais() { return this.nomeCidadeEstadoPais; } //Retornar o nome da cidade, estado e país
        public void setNomeCidadeEstadoPais(string cidadeEstadoPais) //Atribuir um valor de string, com o nome da cidade, estado e o país
        {
            this.nomeCidadeEstadoPais = cidadeEstadoPais;
        }
        #endregion

        #region ToStringAtributos
        public override string? ToString()
        {
            string mensagem = $"Endereço: \n{nomeRua}, {numCasa}, {nomeBairro}, {nomeCidadeEstadoPais}";
            return mensagem;
        }
        #endregion
    }
}
