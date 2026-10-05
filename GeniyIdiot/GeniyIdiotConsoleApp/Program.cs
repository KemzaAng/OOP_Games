using System;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        while (true)
        {
            string choice = GameMenu();

            if (choice == "1")
            {
                StartFullGame();
            }
            else if (choice == "2")
            {
                var allUsers = UsersResultStorage.LoadAll();

                if (allUsers.Count == 0)
                {
                    Console.WriteLine("Файл с результатами пока не создан.");
                    return;
                }

                string displayFormat = "|| {0,-20} || {1 , -18} || {2 , -10} ||";

                Console.WriteLine("\nТаблица результатов:\n");

                Console.WriteLine(displayFormat, "Имя игрока", "Количество ответов", "Диагноз");

                foreach (var user in allUsers)
                {
                    Console.WriteLine(displayFormat, user.Name, user.CorrectAnswers, user.Diagnosis);
                }

            }
            else if (choice == "3")
            {
                AddNewQuestion();
            }
            else if (choice == "4")
            {
                RemoveQuestoin();
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }

    static void StartFullGame()
    {
        while (true)
        {
            Console.WriteLine("Назовись! Чтобы диагноз был персональным.");
            string userName = Console.ReadLine();

            var user = new User(userName);

            var questions = QuestionsRepository.GetQuestions();

            int correctCount = StartGame(questions);

            string diagnosis = Diagnosis.GiveStatus(correctCount, questions.Count);

            user.SetResult(correctCount, diagnosis);

            Console.WriteLine($"\nКоличество правильных ответов: {user.CorrectAnswers}");

            Console.WriteLine($"Ваш диагноз {user.Name}: {user.Diagnosis}");

            UsersResultStorage.Save(user);

            if (!IsPlayAgain(user.Name))
            {
                Console.WriteLine($"\nСпасибо за игру, {user.Name}!");
                break;
            }
        }
    }

    static string GameMenu()
    {
        Console.WriteLine("\nВыберите действие:\n");
        Console.WriteLine("1 - Играть");
        Console.WriteLine("2 - Показать все результаты");
        Console.WriteLine("3 - Добавить новый вопрос");
        Console.WriteLine("4 - Удалить существующий вопрос");
        Console.WriteLine("5 - Выйти\n");

        string choice = Console.ReadLine();
        return choice;
    }

    static int StartGame(List<Question> questions)
    {
        int correctAnswersCount = 0;

        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine($"\nВопрос №{i + 1}\n{questions[i].Text}");

            int userAnswer = GetUserAnswer();

            if (userAnswer == questions[i].Answer)
            {
                correctAnswersCount++;
            }
        }

        return correctAnswersCount;
    }

    static int GetUserAnswer()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                return result;
            }

            Console.WriteLine("Пожалуйста, введите число от 0 до 1000!");
        }

    }  

    static bool IsPlayAgain(string userName)
    {
        Console.WriteLine("\nЖелаете пройти игру еще раз?\nНапишите да или нет");

        while (true)
        {
            string playAgain = Console.ReadLine().ToLower();

            if (playAgain == "да")
            {
                return true;
            }
            if (playAgain == "нет")
            {
                return false;
            }

            Console.WriteLine("\nПожалуйста, напишите да или нет\n");
        }
    }

    static void AddNewQuestion()
    {
        Console.WriteLine("Введите новый вопрос:");

        string question = Console.ReadLine();

        Console.WriteLine("Введите ответ (целое число до 1000):");

        var answer = GetUserAnswer();

        var questions = QuestionsRepository.GetQuestions();

        var newQuestion = new Question(question, answer);

        questions.Add(newQuestion);

        QuestionsRepository.SaveQuestions(questions);       

        Console.WriteLine("Вопрос успешно добавлен!");
    }
    static void RemoveQuestoin()
    {
        Console.WriteLine("Выберите номер вопроса для удаления");

        var questions = QuestionsRepository.GetQuestions();
        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {questions[i].Text}");
        }

        var numberAnswer = GetUserAnswer();

        while (numberAnswer < 1 || numberAnswer > questions.Count)
        {
            Console.WriteLine($"Ввидите число от 1 до {questions.Count}");
            numberAnswer = GetUserAnswer();
        }

        questions.RemoveAt(numberAnswer - 1);

        QuestionsRepository.SaveQuestions(questions);

        Console.WriteLine("Вопрос успешно удалён.");
    }
}


