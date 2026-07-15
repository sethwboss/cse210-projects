# Flashcard Study and Quiz System

A command-line C# application that helps users learn, memorize, and review terms and definitions through customizable study sets and interactive quizzes. The application includes gamified elements such as score tracking and study ranks to encourage consistent learning.

---

## Features

1. **Study Set Management**:
   - **Create Study Sets**: Define a set name and add a custom number of flashcards with terms and definitions.
   - **View Study Sets**: Display terms and definitions of any created study set in a clear, readable format.
   - **Delete Study Sets**: Remove completed or unwanted study sets.

2. **Interactive Quizzes**:
   - **Term Quiz (Name Quiz)**: Displays definitions and prompts the user to type the corresponding term.
   - **Definition Quiz (Term Quiz)**: Displays terms and prompts the user to type the corresponding definition.
   - **Multiple Choice Quiz**: Generates a 4-choice question for each definition using randomized distractors from the active study set (requires at least 4 flashcards in the set).
   
3. **Scoring & Gamification**:
   - Earn **1 point** for each correct answer.
   - Earn a **10-point bonus** for a perfect score (getting all questions right in a quiz).
   - Unlock ranks:
     - **EXPERT**: Reach 100 points.
     - **MASTER**: Reach 500 points.

