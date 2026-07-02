public class TermQuiz : Quiz
{
    public TermQuiz() : base("Name Quiz", "the terms of each flashcard, as you are given the definitions.")
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
            Console.WriteLine($"Definition: {currentDefinition}");
            Console.Write("Term: ");

            string answer = Console.ReadLine();

            if (answer == currentTerm)
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