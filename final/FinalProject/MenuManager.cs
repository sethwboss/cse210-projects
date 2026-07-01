using Microsoft.VisualBasic.FileIO;

public class MenuManager
{

    private List<StudySet> _allStudySets = new List<StudySet>{};
    public void CreateStudySet()
    {
        Console.WriteLine();
        Console.Write("What is the name of your Study Set? ");
        string setName = Console.ReadLine();
        Console.Write("How many flashcards would you like in this study set? (If you have 3 terms & 3 definitions, enter 3): ");
        int loopAmount = int.Parse(Console.ReadLine());

        int count = 0;
        StudySet studySet = new StudySet(setName);
        while (count < loopAmount)
        {
            Console.WriteLine();
            Console.Write("Enter the term: ");
            string term = Console.ReadLine();

            Console.Write("Enter the definition: ");
            string definition = Console.ReadLine();

            FlashCard flashcard = new FlashCard(term, definition);
            studySet.AddCard(flashcard);
            count ++;
        }
        _allStudySets.Add(studySet);
        Console.WriteLine();
        Console.WriteLine("Your study set has been created!");
        Console.WriteLine();
    }

    public void DisplayStudySets()
    {
        Console.WriteLine();
        Console.WriteLine("Here are the current Study Sets:");

        int count = 0;
        foreach (StudySet studySet in _allStudySets) {
            count ++;
            string studySetName = studySet.GetStudySetName();
            Console.WriteLine($"{count}. {studySetName}");
        }
    }

    public void SeeStudySet()
    {
        DisplayStudySets();
        Console.WriteLine();
        Console.Write("Which study set would you like to view? (type the number 1, 2, etc.): ");
        int selectedNum = int.Parse(Console.ReadLine());
        Console.WriteLine();

        StudySet selectedStudySet = _allStudySets[selectedNum - 1];
        Console.WriteLine(selectedStudySet.GetStudySetString());

    }
    public void DelStudySet()
    {
        DisplayStudySets();
        Console.WriteLine();
        Console.Write("Which study set would you like to delete? (type the number 1, 2, etc.): ");
        int selectedNum = int.Parse(Console.ReadLine());
        Console.WriteLine();
        _allStudySets.RemoveAt(selectedNum - 1);

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