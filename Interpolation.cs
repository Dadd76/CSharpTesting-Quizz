namespace quiz.net_intermediate;

     /* Quel est l'exemple d'interpolation de chaîne de caractère ci-dessous qui ne compilera pas ?   
    A)  Console.WriteLine($"{Name} says hit to {other.name} (born {other.DateOfBirth.Year < 1975 ? "oldies : "youngster"})");
    B)  Console.WriteLine($"{Name} says hit to {other.name} (born {((Func<int> (() => {int x=10 ; return x; } ))()})");
    C)  Console.WriteLine(FormattableString.Invariant($"{Name} says hit to {other.name} (born {DateOfBirth})");
    D) Toutes ces réponses
    */
public class Interpolation : IQuizz
{
   private string Name ="Robert";
   private DateTime DateOfBirth  = new DateTime(1975, 5, 27);
   public Person other;

   public class Person 
   {
    public DateTime DateOfBirth  = new DateTime(1975, 5, 27);
    public string Name = "Gérard";
   }

    delegate int NumberChanger(int n);


    public Interpolation()
    {
    other = new Person();
    }

    public void runQuizz()
    {
     Console.WriteLine($"{Name} says hit to {other.Name} (born {(other.DateOfBirth.Year < 1975 ? "oldies" : "youngster")})"); 
     //manque () sur l expression conditionnel 

     //Console.WriteLine($"{Name} says hit to {other.Name} (born {((Func<int> (() => {int x=10 ; return x; } ))())})"); 
     //error CS1955: Impossible d'utiliser un membre 'Func<TResult>' ne pouvant pas être appelé comme une méthode.

     Console.WriteLine(FormattableString.Invariant($"{Name} says hit to {other.Name} (born {DateOfBirth})"));
     //manque une parenthèse à la fin 
    }
}
