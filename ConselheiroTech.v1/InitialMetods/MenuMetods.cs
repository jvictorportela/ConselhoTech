

namespace ConselheiroTech.v1.InitialMetods;


public class BasicMetods
{
    public void AbrirMenu()
    {
        Console.WriteLine($"*** Seja bem vindo ao Conselheiro Tech ***");
        Console.WriteLine($"1 --> Receber um conselho. ");
        //Console.WriteLine($"2 --> Ver conselhos anteriores. ");
        Console.WriteLine($"3 --> Sair do Conselheiro Tech. ");

        int answer = Convert.ToInt32(Console.ReadLine());

        switch (answer)
        {
            case 1:
            {
                //chamar método
                Console.WriteLine($"Seu conselho do dia é:");
                Thread.Sleep(2000);
                Console.WriteLine("Preparando seu conselho...");
                Thread.Sleep(2000);
                //Chamar conselho
                Thread.Sleep(5000);
                AbrirMenu();
                break;
            }
            // case 2:
            // {
            //     //chamar método
            //     
            //     break;
            // }
            case 3:
            {
                Console.WriteLine("Volte sempre, bye bye...");
                Thread.Sleep(1500);
                break;
            }
        }
    }

    public void RetornarAoMenu()
    {
        AbrirMenu();
    }
}