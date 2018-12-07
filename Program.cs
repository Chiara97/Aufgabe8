using System;

namespace Aufgabe8
{
    class Program
    {
        public int score = 0;
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.QuizMenu(p.score);
        }

        public void QuizMenu(int score)
        {
            Console.WriteLine("Deine Punktzahl: " + score);
            Console.WriteLine("Tippe 1: Quiz beantworten");
            Console.WriteLine("Tippe 2: Fragen hinzufügen");
            Console.WriteLine("Tippe 3: Programm beenden");

            int choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                ChooseQuestionType(score);
            }
            
            if(choice == 2)
            {
                Program p = new Program();
                p.AddNewQuestion();
            }

            else
            {
                Console.WriteLine("Auf Wiedersehen.");
            }
        }

        public void ChooseQuestionType(int score)
        {
            Console.WriteLine("Welchen Fragetyp willst du beantworten?");
            string type = Console.ReadLine();

            if (type == "QuizSingle")
            {
                QuizSingle single = new QuizSingle();
                single.AnswerQuizSingle(score);
            }
            if (type == "QuizMultiple")
            {
                QuizMultiple multiple = new QuizMultiple();
                multiple.AnswerQuizMultiple(score);
            }
            if (type == "QuizBinary")
            {
                QuizBinary binary = new QuizBinary();
                binary.AnswerQuizBinary(score);
            }
            if (type == "QuizGuess")
            {
                QuizGuess guess = new QuizGuess();
                guess.AnswerQuizGuess(score);
            }
            if (type == "QuizFree")
            {
                QuizFree free = new QuizFree();
                free.AnswerQuizFree(score);
            }
        }
        
        public void AddNewQuestion()
        {
            Console.WriteLine("Gib eine neue Frage ein:");
            string addUserQuestion = Console.ReadLine();

            Console.WriteLine("Wie viele Antwortmöglichkeiten soll deine Frage haben?");
            int addHowManyAnswers = int.Parse(Console.ReadLine());

            Console.WriteLine("Schreibe die richtige Antwort:");
            string userAnswer = Console.ReadLine();

            int i = 1;

            while(i < addHowManyAnswers)
            {
                Console.WriteLine("Schreibe die nächste Antwortmöglichkeit");
                userAnswer = Console.ReadLine();
                i++;
            }
            QuizMenu(score);

        }
    }
}
