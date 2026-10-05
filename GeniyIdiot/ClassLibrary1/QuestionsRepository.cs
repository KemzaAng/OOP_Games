using Newtonsoft.Json;

public static class QuestionsRepository
{
    private static readonly string _folderPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "MyGameApp"
    );

    private static readonly string _fileName = Path.Combine(_folderPath, "questions.json");

    public static List<Question> GetQuestions()
    {
        var questions = new List<Question>();

        if (FileManager.Exists(_fileName))
        {
            string value = File.ReadAllText(_fileName);

            questions = JsonConvert.DeserializeObject<List<Question>>(value);
        }
        else
        {
            questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
            questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));

            SaveQuestions(questions);
        }

        ShuffleQuestions(questions);

        return questions;
    }

    public static void LoadUserQuestions(List<Question> questions)
    {
        var question = GetQuestions();

        question.AddRange(questions);

        SaveQuestions(question);
    }

    public static void ShuffleQuestions(List<Question> questions)
    {
        Random randomGenerator = new Random();

        for (int currentIndex = questions.Count - 1; currentIndex > 0; currentIndex--)
        {
            int randomIndex = randomGenerator.Next(currentIndex + 1);

            var temp = questions[currentIndex];
            questions[currentIndex] = questions[randomIndex];
            questions[randomIndex] = temp;
        }
    }

    public static void SaveQuestions(List<Question> questions)
    {
        var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);

        File.WriteAllText(_fileName, jsonData);
    }
}








