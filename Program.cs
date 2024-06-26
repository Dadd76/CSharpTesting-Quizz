﻿using System;
using quiz.net_intermediate;


namespace quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            var quizz1 = new QuizzGeneric();
            quizz1.runQuizz();

            var quizz2  = new Constructeur();
            quizz2.runQuizz();

            var quizz3 = new Stack();
            quizz3.runQuizz();

            var quizz4 = new AddAditionalText();
            quizz4.runQuizz();

            var quizz5 = new NullableTest();
            quizz5.runQuizz();

            var quizz6 = new DelegateMulticast();
            quizz6.runQuizz();

            var quizz7 = new Interpolation();
            quizz7.runQuizz();
            
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

    /* Quel est l'intérêt d'utiliser un "AppDomain" en .Net
    A) Pour scoper et limiter a l'aAppDomain els problème pouvant apparaitre pendant l'éxécution
    B) Pour appliquer la configuration de sécurité granulaire limité a l'AppDomain
    C) Pour décrire le domain bussiness dans le fichier PropertyInfo.cs
    D) Pour limiter à une seule application le nombre d'applications éxécutées par un thread
    E) Les réponses A et B 
    F) Les réponses B et D
    */

    /* Etant donnée le bloc de code suivant. Quel sera le résulat de "throw ex"
    try
    {
        System.IO.FILE.Open("{LOCATION," System.IO.FileMode.Append")
    }
    catch (System.IO.IOException ex)
    {
        throw ex;
    }
    A) Il remplacera la trace de pile initiale de l'exception par els informations de trace de pile 
    du point "re throw"
    B) Ue exception sera passée aux niveaux plus élevés sans aucune modification
    C) Une fois capturée, une exception ne peux plus être lancé
    */


    /* peut-on annuler une opération Asyn en c# 
    A) Non, vous devez attendre que l'opération se termine
    B) Oui, vous pouvez utiliser Cancellation Token,
    C) Oui, vous pouvez utiliser Cancellation TokenSource,
    D) Oui, vous pouvez utiliser Cancellation TokenSource et Cancellation Token,
    */
    
    /* volatile
    A) Le mot clef volatile indique qu'un champ peut être modifié par plusieurs threads
    B) q'un champ peut être modifié par le thread principal
    C) Le mot clef volatile indique qu'un champ ne peut être pas modifié par plusieurs threads
    */

     /* Quel est l'exemple d'interpolation de chaîne de caractère ci-dessous qui ne compilera pas ?   
    A)  Console.WriteLine($"{Name} says hit to {other.name} (born {other.DateOfBirth.Year < 1975 ? "oldies : "youngster"})");
    B)  Console.WriteLine($"{Name} says hit to {other.name} (born {((Func<int> (() => {int x=10 ; return x; } ))()})");
    C)  Console.WriteLine(FormattableString.Invariant($"{Name} says hit to {other.name} (born {DateOfBirth})");
    D) Toutes ces réponses
    */

     /* Quel interface devrait être implémentée par une classe qui pourrait être utilisée à l'intérieur du bloc "using(..){}"
    A) IDisposable
    B) IClosable
    C) Idestroyable
    D) Toutes ces réponses
    */