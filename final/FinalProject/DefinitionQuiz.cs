public class DefinitionQuiz : Quiz
{
    public DefinitionQuiz() : base("Term Quiz", "the definitions for each flashcard, as you are given the names.")
    {
    
    }


    public override int RunQuiz(StudySet studyset)
    {
        DisplayBeg();
        string name = studyset.GetStudySetName();
        Console.WriteLine($"{name}: ");
        DisplayQuestions(studyset);

        DisplayEnding();
        return _points;
    }

    public override void DisplayQuestions(StudySet studyset)
    {
        List<FlashCard> studyList = studyset.GetStudyList();

        int count = 0;
        foreach (FlashCard flashcard in studyList)
        {
            count ++;
            string currentTerm = flashcard.GetTerm();
            string currentDefinition = flashcard.GetDefinition();

            Console.WriteLine();
            Console.WriteLine($"Term: {currentTerm}");
            Console.Write("Definition: ");

            string answer = Console.ReadLine();

            if (answer == currentDefinition)
            {
                _points ++;
            }


        }
        if (count == _points)
        {
            _points += 10;
        }
    }
}