namespace quiz.net_intermediate;

public class Constructeur : IQuizz
{
    /* La propiété doit être visible et accessible par toute les class mais seulement modificable 
    par le code l'intérieur de class BankAccount ou d'une class dérivé depuis la class BankAccount
    A) remplacer set par protected set
    B) remplacer public Guid AccountId
    C) private get / private set
    D) protected class BankAccount
    */ 

public void runQuizz()
    {
        throw new NotImplementedException();
    }
}

public class BankAccount
{
    public Guid AccountId
    {
        get;
        set;
    }
}