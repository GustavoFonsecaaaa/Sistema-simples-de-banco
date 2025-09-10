internal class Program
{
    private static void Main(string[] args)
    {
        int opc;
        double saldo, saque, depo, paga, transf;
        Console.WriteLine("Qual seu saldo bancário?");
        saldo = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual operação você deseja fazer?");
        Console.WriteLine("1) Saque");
        Console.WriteLine("2) Depósito");
        Console.WriteLine("3) Pagamento de conta");
        Console.WriteLine("4) Transfêrencia");
        opc = int.Parse(Console.ReadLine());

        if (opc == 1)
        {
            Console.WriteLine("Quanto você deseja retirar?");
            saque = double.Parse(Console.ReadLine());
            saque = saldo - saque;
            Console.WriteLine("Seu saldo agora é: R$ " + saque);
        }
        else if (opc == 2)
        {
            Console.WriteLine("Quanto você gostaria de depositar?");
            depo = double.Parse(Console.ReadLine());
            depo = depo + saldo;
            Console.WriteLine("Depósito realizado.");
            Console.WriteLine("Seu saldo agora é: R$ " + depo);
        }
        else if (opc == 3)
        {
            Console.WriteLine("Qual valor da conta?");
            paga = double.Parse(Console.ReadLine());
            paga = saldo - paga;
            Console.WriteLine("Pagamento realizado.");
            Console.WriteLine("Seu saldo agora é: R$ " + paga);
        }
        else
        {
            Console.WriteLine("Quanto você deseja transferir?");
            transf = double.Parse(Console.ReadLine());
            transf = saldo - transf;
            Console.WriteLine("Transfêrencia realizado.");
            Console.WriteLine("Seu saldo agora é: R$ " + transf);
        }
        
        
           
    }
}