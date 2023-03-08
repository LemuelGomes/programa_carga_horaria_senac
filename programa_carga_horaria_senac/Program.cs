string[,] senac = new string[3, 5];
int linha, coluna;
int opcao;
coluna = 0;
string pesquisar;
string voltar = "S";
double total = 0;
double conta1 = 0;
double conta2 = 0;


Console.WriteLine("Aplicativo para Calcular a quantidade de FALTAS que você pode ter em uma Unidade Curricular 'UC'\n\n\nAperte qualquer tecla para inicar o programa");
Console.ReadLine();
Console.Clear();

while (voltar == "S" || voltar == "s")
{
    Console.WriteLine("Para realizar o Cadastro DIGITE '1' \n\nPara ver oque está Cadastrado DIGITE '2' \n\nPara ver a quantidade que você poderá FALTAR digite '3' ");
    opcao = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcao)
    {
        case 1:
            {
                for (linha = 0; linha < 3; linha++)
                {
                    Console.WriteLine("Digite o número da UC que deseja CADASTRAR: ");
                    senac[linha, coluna++] = Console.ReadLine();
                    Console.WriteLine("\nDigite a Descrição da UC: ");
                    senac[linha, coluna++] = Console.ReadLine();
                    Console.WriteLine("\nPor último digite agora a Carga Horária desta UC: ");
                    senac[linha, coluna++] = Console.ReadLine();

                    coluna = 0;
                    Console.Clear();
                }
                Console.WriteLine("Deseja Voltar ao Menu inical? 'S' ou 'N' ");
                voltar = Console.ReadLine();
                Console.Clear();
                break;
            }

        case 2:
            {
                for (linha = 0; linha < 3; linha++)
                {
                    Console.Write("Número da UC: " + senac[linha, 0] + " - A descrição da UC: " + senac[linha, 1] + " - Está UC terá em HORAS: " + senac[linha, 2] + "h\n");
                }
                Console.WriteLine("\n\nDeseja Voltar ao Menu inical? 'S' ou 'N' ");
                voltar = Console.ReadLine();
                Console.Clear();
                break;
            }

        case 3:
            {                
                Console.WriteLine("Qual Unidade Curricular 'UC' você Deseja Verificar? 'Está unidade Curricular digitada vai trazer a quantidade de FALTAS que você poderá FALTAR.' ");
                pesquisar = Console.ReadLine();

                for (linha = 0; linha < 3; linha++)
                {
                    if (pesquisar == senac[linha, 0])
                    {
                        conta1 = double.Parse(senac[linha, 2]) * 0.25;
                        conta2 = double.Parse(senac[linha, 2]);
                        total = conta1 / conta2;
                        Console.WriteLine("Número da UC: " + senac[linha, 0] + "\n\nA descrição da UC: " + senac[linha, 1] + "\n\nEstá UC terá em HORAS: " + senac[linha, 2] +"h" + "\n\nE você poderá faltar " + total.ToString("F") + " dias, ou: " + conta1 + " horas de aula");                         
                    }
                }
                Console.WriteLine("\n\nDeseja Voltar ao Menu inical? 'S' ou 'N' ");
                voltar = Console.ReadLine();
                Console.Clear();
                break;
            }
    }
}