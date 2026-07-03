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
            count ++;
            string currentTerm = flashcard.GetTerm();
            string currentDefinition = flashcard.GetDefinition();

            string[] FourTerms = new string [4];
            FourTerms[3] = currentTerm;

            int count2 = 0;
            while (count2 < 3)
            {
                int randomIndex = random.Next(studyList.Count);
                FlashCard randomFlashcard = studyList[randomIndex];
                string newTerm = randomFlashcard.GetTerm();
                if (!FourTerms.Contains(newTerm))
                {
                    FourTerms[count2] = newTerm;
                    count2 ++;
                }
            }

            string[] RandomizedTerms = new string [4];

            int count3 = 0;
            while (count3 < 4)
            {
                int randomIndex = random.Next(4);
   
                if (!RandomizedTerms.Contains(FourTerms[randomIndex]))
                {
                    RandomizedTerms[count3] = FourTerms[randomIndex];
                    count3 ++;
                }

            }

            Console.WriteLine();
            Console.WriteLine($"Question {count}. Which of the following terms best match this definition? '{currentDefinition}'");
            Console.WriteLine($"1. {RandomizedTerms[0]}");
            Console.WriteLine($"2. {RandomizedTerms[1]}");
            Console.WriteLine($"3. {RandomizedTerms[2]}");
            Console.WriteLine($"4. {RandomizedTerms[3]}");
            Console.WriteLine();
        

            Console.Write("Answer (type 1, 2, 3, or 4): ");

            string answer = Console.ReadLine();
            int intAnswer = int.Parse(answer);
            
            int count4 = 0;
            int position = 0;
            bool booler = true;
            while (booler)
            {
                if (RandomizedTerms[count4] == currentTerm)
                {
                    booler = false;
                    position = count4 + 1;
                }

                count4 ++;
            }
            

            if (intAnswer == position)
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