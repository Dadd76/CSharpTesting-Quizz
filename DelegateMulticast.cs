namespace quiz.net_intermediate;

    /* Comment la valeur initial "num" va-t-elle changer lorsque vous appelez le délégué multicast 
    "ncAggregation" ?
    A) Value of Num : {ncAggregation(5)}
    B) Value of Num : 75
    C) Value of Num : 15
    D) Value of Num : 55
    */ 

public class DelegateMulticast : IQuizz
{
    static int num = 10 ;
    public static int Add(int p) {return (num+= p); }
    public static int Multiply(int q) {return (num*= q); }

    delegate int NumberChanger(int n);


    public DelegateMulticast()
    {

    }

    public void runQuizz()
    {
        NumberChanger ncAggregation;
        NumberChanger ncAdd = new NumberChanger(Add);
        NumberChanger ncMultiply = new NumberChanger(Multiply);
        ncAggregation =  ncAdd;
        ncAggregation += ncMultiply;

        Console.WriteLine($"Value of Num : {ncAggregation(5)}");
    }
}
