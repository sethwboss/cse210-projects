public class MultipleQuiz : Quiz
{
  

    public MultipleQuiz() : base("Multiple Choice Quiz", "a definition for each question, and must type the correct name from 4 different options.")
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
            int count2 = 0;
            string[] randomTerms = new string [3];
            while (count2 < 3)
            {
                Random random = new Random();
                int randomIndex = random.Next(studyList.Count);
                FlashCard randomFlashcard = studyList[randomIndex];
                randomTerms[count2] = randomFlashcard.GetTerm();

                count2 ++;
            }

            count ++;
            string currentTerm = flashcard.GetTerm();
            string currentDefinition = flashcard.GetDefinition();

            string[] totalTerms = new string [4];


            int count3 = 1;
            while (count3 < 4)
            {

                Console.WriteLine();

                bool loop = true;
                while (loop)
                {
                    Random random = new Random();
                    int randomIndex = random.Next(4);
                    if (totalTerms[randomIndex] == "")
                    {
                        //Console.WriteLine($"{count3}. {totalTerms[randomIndex]}");
                        loop = false;
                        totalTerms[randomIndex] = randomTerms[randomIndex];
                    }
                }

                count3 ++;
            }
            Console.WriteLine($"1. {totalTerms[1]}");
            Console.WriteLine($"1. {totalTerms[2]}");
            Console.WriteLine($"1. {totalTerms[3]}");
            Console.WriteLine($"1. {totalTerms[4]}");

        

            Console.Write("Answer: ");

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