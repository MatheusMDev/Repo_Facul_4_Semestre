namespace ProjetoContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declarar variáveis
            double valor = 0.0;
            int opcao = 0;
            string msg = null;

            // instaciar um objeto da classe ContaEspecial
            ContaEspecial contaEsp = new ContaEspecial();
            // fazendo a abertura da conta especial
            try
            {
                Console.WriteLine("Nome do Cliente: ");
                contaEsp.NomeCliente = Console.ReadLine();
                Console.WriteLine("Número da Conta: ");
                contaEsp.NroConta = Console.ReadLine();
                Console.WriteLine("Depósito Inicial R$ ");
                valor = Convert.ToDouble(Console.ReadLine());
                // chamar a execução do metodo Abertura, passar o valor do Deposito inicial
                contaEsp.Abertura(valor);
                msg = "Conta aberto com sucesso!" +
                    "Gasta vagabundo";
            }
            catch (Exception erro)
            {
                msg = "Não foi possível abrir a conta." +
                    "Veja o erro" + erro;
            }
            finally
            {
                Console.WriteLine(msg);
            }
            do
            {
                Console.Write("\n---Menu---\n" +
                    "1 - Sacar\n" +
                    "2 - Depositar \n" +
                    "3 - Consultar saldo\n" +
                    "4 - Finalizar programa \n " +
                    "Digite sua opção: \n");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Write("\nValor do Saque R$ ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        contaEsp.Sacar(valor);
                        break;

                    case 2:
                        Console.Write("\nValor do Deposito R$ ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        contaEsp.Depositar(valor);
                        break;

                    case 3:
                        Console.Write("\nNome do Cliente" +
                            contaEsp.NomeCliente +
                            "\nNúmero da Conta: " +
                            contaEsp.NroConta +
                            "\nSeu Saldo + Limite R$ " +
                            (contaEsp.VerificaSaldo() + contaEsp.Limite));
                        break;

                    case 4:
                        Console.WriteLine("\n Programa finalizado com sucesso! É muito bom ganhar dinheiro seu gratuito");
                        break;
                    default:
                        Console.WriteLine("\n Opção invalida" +
                            "Tente novamente.");
                        break;
                }
            } while (opcao != 4);
        }
    }
}
