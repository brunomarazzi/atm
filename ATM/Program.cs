using System;

namespace ATM;

    static class Program 
    {
        // ATM Machine. My second project for practicing purposes using C#.
        static void Main()
        {
            Client client = new Client();
        client.Name = "Bruno";
        client.CPF = 66666666666;
        client.Agency = 123;
        client.Account = 456789;

        Console.WriteLine(client.Name);
        Console.WriteLine(client.CPF);
        Console.WriteLine(client.Agency);
        Console.WriteLine(client.Account);
       
        Console.ReadKey();

        }
    }
