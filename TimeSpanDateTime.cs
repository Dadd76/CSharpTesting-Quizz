using System.Dynamic;

namespace quiz.net_intermediate;


/* Quelle serait une version plus légère et plus courte de la propriété ci-dessus ?  
A) public TimeSpan Age => DateTime.UtcNow - DateOfBirth
B) public TimeSpan Age => DateTime.UtcNow - this.DateOfBirth
C) public TimeSpan Age() => DateTime.UtcNow - this.DateOfBirth
D) A & B
E) A & B & C
*/


public class TimeSpanDateTime : IQuizz
{

    public TimeSpan Age1 => DateTime.UtcNow - DateOfBirth ;
    public TimeSpan Age2 => DateTime.UtcNow - this.DateOfBirth ;


    public DateTime DateOfBirth{get; set;}
    public TimeSpan Age
    {

        get {return DateTime.UtcNow - DateOfBirth;}
    }

    public void runQuizz()
    {
        
    }
}
