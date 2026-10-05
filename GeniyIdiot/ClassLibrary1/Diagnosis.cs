
public static class Diagnosis
{   
    public static string GiveStatus(int correctAnswers, int totalQuestions)
    {
        if (totalQuestions == 0)
        {
            return "кретин";
        }

        double percent = (double)correctAnswers / totalQuestions * 100;

        if (percent < 20)
        {
            return "кретин";
        }
        if (percent < 40)
        {
            return "идиот";
        }
        if (percent < 60)
        {
            return "дурак";
        }
        if (percent < 80)
        {
            return "нормальный";
        }
        if (percent < 100)
        {
            return "талант";
        }

        return "гений";
    }
}








