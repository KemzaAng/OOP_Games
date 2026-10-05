public class User
{
    public string Name;
    public int CorrectAnswers;
    public string Diagnosis;

    public User(string name)
    {
        Name = name;
    }

    public void SetResult(int correctAnswers, string diagnosis)
    {
        CorrectAnswers = correctAnswers;
        Diagnosis = diagnosis;
    }
}


