public class MultipleQuiz : Quiz
{
  

    public MultipleQuiz() : base("Multiple Choice Quiz", "a definition for each question, and must type the correct term from 4 different options.")
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
        Random random = new Random();

        int count = 0;
        foreach (FlashCard flashcard in studyList)
        {
            int count2 = 0;
            string[] randomTerms = new string [4];
            while (count2 < 3)
            {
                int randomIndex = random.Next(studyList.Count);
                FlashCard randomFlashcard = studyList[randomIndex];
                randomTerms[count2] = randomFlashcard.GetTerm();

                count2 ++;
            }

            count ++;
            string currentTerm = flashcard.GetTerm();
            string currentDefinition = flashcard.GetDefinition();

            randomTerms[3] = currentTerm;

            string[] totalTerms = new string [4];

            int count3 = 1;
            while (count3 < 4)
            {

                Console.WriteLine();
                int count4 = 0;
                bool loop = true;
                while (loop)
                {
                    int randomIndex = random.Next(4);
                    if (totalTerms[randomIndex] == null)
                    {
                        //Console.WriteLine($"{count3}. {totalTerms[randomIndex]}");
                        totalTerms[randomIndex] = randomTerms[randomIndex];
                        count4 ++;
                    }
                    if (count4 == 3)
                    {
                        loop = false;
                    }
                }

                count3 ++;
            }
            Console.WriteLine($"What is the term for {currentDefinition}");
            Console.WriteLine($"1. {totalTerms[0]}");
            Console.WriteLine($"2. {totalTerms[1]}");
            Console.WriteLine($"3. {totalTerms[2]}");
            Console.WriteLine($"4. {totalTerms[3]}");
            Console.WriteLine();
        

            Console.Write("Answer: ");

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