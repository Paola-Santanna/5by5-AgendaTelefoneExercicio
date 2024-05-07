/*
 * Faça um programa que crie uma agenda de telefone
 * - Nome completo
 * - Telefone (string) (lista telefones)
 * - Endereço (objeto endereço apenas 1)
 * - Email
 * 
 * Mostrar (1 ou mais contatos), Adicionar, Remover, Edição;
 */

using Agenda_Telefone_Exercicio;

string nome, telefone;
ListaTelefone contato;

//Funções 

#region CadastroContato
void CadastroContato()
{
    int qtdTelefones;

    Console.Write("Nome: ");
    nome = Console.ReadLine();
    contato = new(nome);

    Console.WriteLine("\nQuantos telefones você quer cadastrar? ");
    qtdTelefones = int.Parse(Console.ReadLine());
    
    for (int numero = 0; numero < qtdTelefones; numero++)
    {
        Console.Write("Telefone: ");
        telefone = Console.ReadLine();
        contato.AddTelefoneLista(telefone);
    }

    Console.WriteLine("\n--- Insira os dados do seu endereço ---");
    contato.ReceberEndereco();
}
#endregion

#region ImprimirContato
void ImprimirContato()
{
    contato.ToString();
}
#endregion

//Execução do programa
CadastroContato();
ImprimirContato();