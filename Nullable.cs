namespace quiz.net_intermediate;

public class NullableTest : IQuizz
{
    /* Quelle sera la sortie ? 
    A) New client Dillan with balance 99.9
    B) New client Dillan with balance 0
    C) New client Dillan with balance
    D) erreur de compilation 
    */ 

    public void runQuizz()
    {
       Client dillan = new Client() {Name = "Dillan"};
       Nullable<decimal> dillanBalance  = dillan?.Account?.Balance ;
       Console.WriteLine($"New client {dillan.Name} with balance {dillanBalance}");
    }
}

public class Client
{
    public BankAccount2 Account {get; set;} 
    public string Name {get; set;} 
}

public class BankAccount2
{
    public decimal Balance {get; set;} = 99.9m; 
   
}