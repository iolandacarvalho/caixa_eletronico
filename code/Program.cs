// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Collections;
using System.Runtime.Serialization;
StreamWriter escrever = new StreamWriter("C:\\Users\\Aluno\\Documents\\Iolanda_Carvalho\\caixa_eletronico\\extrato.txt");
decimal saldo = 500;
decimal deposito = 0;
// declaração de variáveis
int menu;
// fim da declaração de variáveis
Console.Clear();
return1:
Console.Write("Informe o número da sua conta: ");
// writer.WriteLine ("PEDRO BOBAO");
// writer.Close();
if(int.TryParse(Console.ReadLine(), out int numconta))
{
    return2:
    Console.WriteLine("=".PadLeft(40, '='));
    Console.WriteLine("Olá! Seja bem-vindo ao CaliBank.");
    Console.WriteLine("=".PadLeft(40, '='));
    Console.WriteLine("\nInforme o número correspondente à operação que você deseja realizar:");
    Console.WriteLine("\n1 - Acessar conta");
    Console.WriteLine("2 - Saque");
    Console.WriteLine("3 - Deposito");
    Console.WriteLine("4 - Transferência");
    Console.WriteLine("5 - Consultar extrato");
    Console.WriteLine("6 - Sair");

    Console.Write(": ");
    menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
// ACESSAR CONTA
        case 1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("- SUA CONTA -");
            Console.ResetColor();
            Console.WriteLine("\n- Número e tipo da conta: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{numconta} ");
            Console.WriteLine("Conta Corrente ");
            Console.ResetColor();
            Console.WriteLine("\n- Saldo da conta: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"R$ {saldo:F2} ");
            Console.ResetColor();
            Console.WriteLine("\n- Limite de saque e transferência:");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nR$ 5000,00 ");
            Console.ResetColor();

            return3:
            Console.WriteLine("\nSair (s) ou voltar (v)?");
            string souv = Console.ReadLine().ToLower();
            if (souv == "s")
            {
                Console.Clear();
            }
            else if (souv == "v")
            {
                Console.Clear();
                goto return2;
            }
            else
            {
                Console.WriteLine("\n- Valor inválido, tente novamente -");
                Thread.Sleep(1600);
                Console.Clear();
                goto return3;
            }
            break;

// SAQUE
        case 2:
            Console.Clear();
            return4:
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("- SAQUE -");
            Console.ResetColor();
            Console.Write("\nSaldo da conta: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write($"R$ {saldo:F2} ");
            Console.ResetColor();
            Console.Write("\nInforme o valor que você deseja sacar: ");
            decimal saque = decimal.Parse(Console.ReadLine());
            if(saque > saldo || saque < 1 || saque > 5000)
            {
                Console.WriteLine("- Não é possível sacar esse valor. -");
                Thread.Sleep(1600);
                Console.Clear();
                goto return4;
            }
            else 
            {
                Console.Write("\nInforme o número da conta para confirmar o saque: ");
                int confirmacao = int.Parse(Console.ReadLine());
                if(numconta == confirmacao)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n- SAQUE REALIZADO -");
                    escrever.WriteLine("=".PadLeft(30, '='));    
                    escrever.WriteLine($"Saque de {saque:F2} reais realizado.");
                    escrever.WriteLine($"{DateTime.Now}");
                    escrever.WriteLine("=".PadLeft(30, '='));
                    escrever.Close();
                    Console.ResetColor();
                    Thread.Sleep(1600);
                    Console.Clear();
                    return5:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("- SAQUE -");
                    Console.ResetColor();
                    Console.Write("\nSaldo da conta: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    saldo = saldo - saque;
                    Console.Write($"R$ {saldo:F2} ");
                    Console.ResetColor();
                    Console.WriteLine("\n\nSair (s) ou voltar (v)?");
                    string souv2 = Console.ReadLine().ToLower();
                    if (souv2 == "s")
                    {
                        Console.Clear();
                    }
                    else if (souv2 == "v")
                    {
                        Console.Clear();
                        goto return2;
                    }
                    else
                    {
                        Console.WriteLine("\n- Valor inválido, tente novamente -");
                        Thread.Sleep(1600);
                        Console.Clear();
                        goto return5;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n- Número da conta errado. SAQUE BLOQUEADO -");
                    Console.ResetColor();
                    Thread.Sleep(1600);
                    Console.Clear();
                    goto return2;
                }
            }
            
            break;

// DEPÓSITO
        case 3:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("- DEPÓSITO -");
            Console.ResetColor();
            Console.Write("\nSaldo da conta: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write($"R$ {saldo:F2} ");
            Console.ResetColor();
            Console.Write("\nInforme o valor que você deseja depositar: ");
            deposito = decimal.Parse(Console.ReadLine());

            Console.Write("\nInforme o número da conta para confirmar o depósito: ");
                int confirmacao2 = int.Parse(Console.ReadLine());
                if(numconta == confirmacao2)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n- DEPÓSITO REALIZADO -");
                    escrever.WriteLine("=".PadLeft(30, '='));    
                    escrever.WriteLine($"Depósito de {deposito:F2} reais realizado.");
                    escrever.WriteLine($"{DateTime.Now}");
                    escrever.WriteLine("=".PadLeft(30, '='));
                    escrever.Close();
                    Console.ResetColor();
                    Thread.Sleep(1600);
                    Console.Clear();
                    return5:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("- DEPÓSITO -");
                    Console.ResetColor();
                    Console.Write("\nSaldo da conta: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    saldo = saldo + deposito;
                    Console.Write($"R$ {saldo:F2} ");
                    Console.ResetColor();
                    Console.WriteLine("\n\nSair (s) ou voltar (v)?");
                    string souv2 = Console.ReadLine().ToLower();
                    if (souv2 == "s")
                    {
                        Console.Clear();
                    }
                    else if (souv2 == "v")
                    {
                        Console.Clear();
                        goto return2;
                    }
                    else
                    {
                        Console.WriteLine("\n- Valor inválido, tente novamente -");
                        Thread.Sleep(1600);
                        Console.Clear();
                        goto return5;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n- Número da conta errado. DEPÓSITO BLOQUEADO -");
                    Console.ResetColor();
                    Thread.Sleep(1600);
                    Console.Clear();
                    goto return2;
                }
            break;

// TRANSFERÊNCIA
        case 4:
            Console.Clear();
            return6:
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("- TRANSFERÊNCIA -");
            Console.ResetColor();
            Console.Write("\nSaldo da conta: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write($"R$ {saldo:F2} ");
            Console.ResetColor();
            Console.Write("\nInforme o valor da transferência: ");
            decimal transferencia = decimal.Parse(Console.ReadLine());
            if(transferencia > saldo || transferencia < 1 || transferencia > 5000)
            {
                Console.WriteLine("- Não é possível transferir esse valor. -");
                Thread.Sleep(1600);
                Console.Clear();
                goto return6;
                
            }
            else
            {
                Console.Write("\nPara quem você irá transferir?\nInforme o número da conta da pessoa: ");
                int numtrans = int.Parse(Console.ReadLine());
            }
            Console.Write("\nInforme o número da SUA conta para confirmar a transferência: ");
            int confirmacao3 = int.Parse(Console.ReadLine());
                if(numconta == confirmacao3)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n- TRANSFERÊNCIA REALIZADA -");
                    escrever.WriteLine("=".PadLeft(30, '='));    
                    escrever.WriteLine($"Transferência de {transferencia:F2} reais realizada.");
                    escrever.WriteLine($"{DateTime.Now}");
                    escrever.WriteLine("=".PadLeft(30, '='));
                    escrever.Close();
                    Console.ResetColor();
                    Thread.Sleep(1600);
                    Console.Clear();
                    return5:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("- TRANSFERÊNCIA -");
                    Console.ResetColor();
                    Console.Write("\nSaldo da conta: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    saldo = saldo - transferencia;
                    Console.Write($"R$ {saldo:F2} ");
                    Console.ResetColor();
                    Console.WriteLine("\n\nSair (s) ou voltar (v)?");
                    string souv2 = Console.ReadLine().ToLower();
                    if (souv2 == "s")
                    {
                        Console.Clear();
                    }
                    else if (souv2 == "v")
                    {
                        Console.Clear();
                        goto return2;
                    }
                    else
                    {
                        Console.WriteLine("\n- Valor inválido, tente novamente -");
                        Thread.Sleep(1600);
                        Console.Clear();
                        goto return5;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n- Número da conta errado. TRANSFERÊNCIA BLOQUEADA -");
                    Console.ResetColor();
                    Thread.Sleep(1600);
                    Console.Clear();
                    goto return2;
                }
        break;

// EXTRATO
        case 5:
            // Console.WriteLine("Você gostaria que seu extrato fosse impresso na tela ou em um arquivo .TXT?");
            // string txt

            break;

// SAIR
        case 6:
            Console.Clear();
            break;
    }
}
else
{
    Console.WriteLine("\n- Número da conta inválido, tente novamente -");
    Thread.Sleep(1600);
    Console.Clear();
    goto return1;
}

