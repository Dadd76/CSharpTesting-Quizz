namespace quiz.net_intermediate;

public class AddAditionalText : IQuizz
{

    string text = "a";

    public void runQuizz()
    {
        AddText(ref text,ref text);
        Console.WriteLine(text);
    }

    string AddText(ref string text1, ref string text2)
    {

        return text1 = $"{text1}{text2}";
    }

}
