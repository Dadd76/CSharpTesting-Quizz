using System;
using quiz.net_intermediate;


namespace quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            var quizz1 = new QuizzGeneric();
            quizz1.runQuizz();

            var quizz2 = new Stack();
            quizz2.runQuizz();

            var quizz3 = new AddAditionalText();
            quizz3.runQuizz();

            var quizz4 = new NullableTest();
            quizz4.runQuizz();
        }

    }
}

    /* Laquelle des méthodes suivantes termine éxécutions différée pour une expression linq 
    A) ToList()
    B) SelectMany()
    C) Where()
    D) Agregate()
    */ 

    /* Laquelle des affirmations suivantes concernant le garbage collector est vraie
    A) Plus la génération d'objets (vieux objets) est élevé, plus faible sont les chances que 
    le garbage collector les détruises
    B) Plus la génération d'objets (nouveaux objets) est base, plus faible sont les chances que 
    le garbage collector les détruises
    C) .NET Framework à la capacité d'explicitement compressé le tas de petit objet (de génération 0)
    pendant la garbage collection
    D) en .NET Framework 4.6 le garbage collector a un rôle de gestionnaire de la mémoire non managé
    */ 