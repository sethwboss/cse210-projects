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

            string[] fourTerms = new string [4];
            fourTerms[3] = currentTerm;

            int countTwo = 0;
            while (countTwo < 3)
            {
                int randomIndex = random.Next(studyList.Count);
                FlashCard randomFlashcard = studyList[randomIndex];
                string newTerm = randomFlashcard.GetTerm();
                if (!fourTerms.Contains(newTerm))
                {
                    fourTerms[countTwo] = newTerm;
                    countTwo ++;
                }
            }

            string[] randomizedTerms = new string [4];

            int countThree = 0;
            while (countThree < 4)
            {
                int randomIndex = random.Next(4);
   
                if (!randomizedTerms.Contains(fourTerms[randomIndex]))
                {
                    randomizedTerms[countThree] = fourTerms[randomIndex];
                    countThree ++;
                }

            }

            Console.WriteLine();
            Console.WriteLine($"Question {count}. Which of the following terms best match this definition? '{currentDefinition}'");
            Console.WriteLine($"1. {randomizedTerms[0]}");
            Console.WriteLine($"2. {randomizedTerms[1]}");
            Console.WriteLine($"3. {randomizedTerms[2]}");
            Console.WriteLine($"4. {randomizedTerms[3]}");
            Console.WriteLine();
        

            Console.Write("Answer (type 1, 2, 3, or 4): ");

            string answer = Console.ReadLine();
            int intAnswer = int.Parse(answer);
            
            int countFour = 0;
            int position = 0;
            bool isFound = true;
            while (isFound)
            {
                if (randomizedTerms[countFour] == currentTerm)
                {
                    isFound = false;
                    position = countFour + 1;
                }

                countFour ++;
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