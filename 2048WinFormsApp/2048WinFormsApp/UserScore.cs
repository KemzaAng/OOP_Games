using _2048WinFormsApp;
using Newtonsoft.Json;

public static class UsersScore
{
    private static readonly string _folderPath = Path.Combine(
       Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
       "MyGameApp"
    );

    private static readonly string _fileName = Path.Combine(_folderPath, "ResultGame2048.json");

    public static void Save(User user)
    {
        if (!Directory.Exists(_folderPath))
        {
            Directory.CreateDirectory(_folderPath);
        }

        var userScore = LoadAll();

        userScore.Add(user);

        SaveData(userScore);
    }

    public static List<User> LoadAll()
    {
        if (!FileManager.Exists(_fileName))
        {
            return new List<User>();
        }

        var fileData = FileManager.ReadAllLines(_fileName);

        var fileScore = string.Join(Environment.NewLine, fileData);

        var userScore = JsonConvert.DeserializeObject<List<User>>(fileScore);

        return userScore;

    }
    public static int LoadRecord()
    {
        if (!File.Exists(_fileName))
        {
            return 0;
        }
        var fileData = File.ReadAllText(_fileName);
        var users = JsonConvert.DeserializeObject<List<User>>(fileData);

        if (users == null || users.Count == 0)
        {
            return 0;
        }
       
        int record = users.Max(u => u.Score); 

        return record;
    }

    public static void SaveData(List<User> usersResult)
    {
        var jsonData = JsonConvert.SerializeObject(usersResult, Formatting.Indented);
        FileManager.WriteAllLines(_fileName, new List<string> { jsonData });
    }
}