public class MenuManager
{

    private List<StudySet> _allStudySets = new List<StudySet>{};
    public void CreateStudySet()
    {
        Console.WriteLine();
        Console.Write("How many flashcards would you like in this study set? (If you have 3 terms & 3 definitions, enter 3): ");
        int loopAmount = int.Parse(Console.ReadLine());

        int count = 0;
        StudySet studySet = new StudySet();
        while (count < loopAmount)
        {
            Console.WriteLine();
            Console.Write("Enter the term: ");
            string term = Console.ReadLine();

            Console.Write("Enter the definition: ");
            string definition = Console.ReadLine();

            FlashCard flashcard = new FlashCard();
            studySet.AddCard(flashcard);
            count ++;
        }
        Console.WriteLine("Here is your study set:");
        Console.WriteLine(studySet.GetStudySetString());
    }
    public void SeeStudySet()
    {
        Console.WriteLine("The goals are:");
        int count = 0;
        foreach (StudySet studySet in _goalList) {
            count ++;

            Console.WriteLine($"{count}. {goal.GetDisplayString()}");

        }
    }
    public void DelStudySet()
    {
        
    }
    public void QuizNames()
    {
        
    }
    public void QuizTerms()
    {
        
    }
    public void MultipleChoiceQuiz()
    {
        
    }
    public void SeeScores()
    {
        
    }
 
    
}