using Microsoft.VisualBasic.FileIO;

public class MenuManager
{

    private List<StudySet> _allStudySets = new List<StudySet>{};
    private int _totalScore = 0;
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
    public void TermQuiz()
    {
        TermQuiz termQuiz = new TermQuiz();

        DisplayStudySets();
        Console.WriteLine();
        Console.Write("Which study set would you like to quiz from? (type the number 1, 2, etc.): ");
        int selectedNum = int.Parse(Console.ReadLine());
        Console.WriteLine();
        StudySet selectedStudySet = _allStudySets[selectedNum - 1];

        int points = termQuiz.RunQuiz(selectedStudySet);
        _totalScore += points;
        
        SeeScores();
    }
    public void DefinitionQuiz()
    {
        DefinitionQuiz definitionQuiz = new DefinitionQuiz();

        DisplayStudySets();
        Console.WriteLine();
        Console.Write("Which study set would you like to quiz from? (type the number 1, 2, etc.): ");
        int selectedNum = int.Parse(Console.ReadLine());
        Console.WriteLine();
        StudySet selectedStudySet = _allStudySets[selectedNum - 1];

        int points = definitionQuiz.RunQuiz(selectedStudySet);
        _totalScore += points;
        
        SeeScores();
    }
    public void MultipleChoiceQuiz()
    {
        MultipleQuiz multipleQuiz = new MultipleQuiz();

        DisplayStudySets();
        Console.WriteLine();
        Console.Write("Which study set would you like to quiz from? (type the number 1, 2, etc.): ");
        int selectedNum = int.Parse(Console.ReadLine());
        Console.WriteLine();
        StudySet selectedStudySet = _allStudySets[selectedNum - 1];

        List<FlashCard> selectedList = selectedStudySet.GetStudyList();

        if (selectedList.Count() > 3) {
            int points = multipleQuiz.RunQuiz(selectedStudySet);
            _totalScore += points;
            SeeScores();
        }
        else
        {
            Console.WriteLine($"This study set only has {selectedList.Count()} flashcards. Need at least 4 flashcards for the multiple choice quiz.");
        }
    }
    public void SeeScores()
    {
        Console.WriteLine();
        Console.WriteLine($"Your total score is {_totalScore} points.");
        Console.WriteLine("If you reach 100 points, you will become an expert of studying, and if you reach 500 points, you will become a master of studying.");

        if (_totalScore >= 100)
        {
            Console.WriteLine();
            Console.WriteLine("Congratulations!! You've reached beyond 100 points. You're achieved the rank of expert at studying.");
        }
        if (_totalScore >= 500)
        {
            Console.WriteLine();
            Console.WriteLine("*** CONGRATULATIONS!! You've reached beyond 100 points. You're achieved the rank of master at studying. ***");
        }
        Console.WriteLine();
    }
 
    
}