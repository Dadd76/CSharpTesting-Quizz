namespace quiz.net_intermediate;

public class QuizzGeneric : IQuizz
{
    /* Quel sera la sortie ? 
    A) MSIL.person
    B) MSIL.generic.person 
    C) Une erreur de compilation car la class person n'implémente pas de constructeur par défaut
    D) Une erreur de compilation car le type généric ne supporte pas "where"
    */ 

   public QuizzGeneric()
   {}

    public void runQuizz()
    {
        Generic<Person> instance = new Generic<Person>();
        Console.WriteLine(instance.Request().GetType());
    }
}


public class Person
{
   public Person()
   {}
 
    public Person(String name)
    {
        Console.WriteLine(name);
    }  
}

public class Generic<T> where T : new()
{

    public T Request()
    {
        return new T();
    }
}

