using EAD_CLASSES_04._12;

Produto produto = new Produto();

while (true)
{
    Console.WriteLine("");
    Console.WriteLine("Escolha uma opção do menu");
    Console.WriteLine("1. Cadastrar produto");
    Console.WriteLine("2. Exibir produto");
    Console.WriteLine("3. Exibir valor total em estoque");
    Console.WriteLine("4. Sair");
    Console.WriteLine(" ");
    Console.Write("Opção: ");
    int escolha = int.Parse(Console.ReadLine());
    Console.WriteLine(" ");
    switch (escolha)
    {
        case 1:
            Console.WriteLine("Informe os dados do produto ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preço = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            break;
        case 2:
            if (produto == null)
                        {
                            Console.WriteLine("Nenhum produto cadastrado ainda.");
                        }
                        else
                        {
                            Console.WriteLine("Dados do produto cadastrado:");
                            Console.WriteLine($"Nome: {produto.Nome}");
                            Console.WriteLine($"Preço: R$ {produto.Preço.ToString("F2")}");
                            Console.WriteLine($"Quantidade: {produto.Quantidade}");}
            break;

        case 3:
           if (produto == null)
                        {
                            Console.WriteLine("Nenhum produto cadastrado ainda.");
                        }
                        else
                        {
                            Console.WriteLine($"Valor total em estoque: R$ {produto.ValorTotal().ToString("F2")}");
                        }
                        break;
        case 4:
            Console.WriteLine("Encerrando o programa...");
            return;
        default:
            Console.WriteLine("Opção inválida! Escolha entre 1 e 4.");
            break;

    }
}



