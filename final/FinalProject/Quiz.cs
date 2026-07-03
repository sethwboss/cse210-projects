public abstract class Quiz
{
    public Quiz(){}

    public Quiz (string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected string _name = "";
    protected string _description ="";

    protected int _points = 0;




    public abstract int RunQuiz(StudySet studyset);

    public void DisplayBeg()
    {
  
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"You will be quizzed on {_description} You can earn 1 point per question and a bonus of 10 if you get all of them right.");
        Console.WriteLine();
    }

    public void DisplayEnding()
    {
        Console.WriteLine();
        Console.Write("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You earned {_points} points from this quiz.");
        Console.WriteLine();
 
    }

    public abstract void DisplayQuestions(StudySet studyset);


}