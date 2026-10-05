
using Newtonsoft.Json;

public static class UsersResultStorage
{
    private static readonly string _folderPath = Path.Combine(
       Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
       "MyGameApp"
    );

    private static readonly string _fileName = Path.Combine(_folderPath, "resultsGame.json");

    public static void Save(User user)
    {
        var userResult = LoadAll();

        userResult.Add(user);

        SaveData(userResult);
    }

    public static List<User> LoadAll()
    {
        if (!FileManager.Exists(_fileName))
        {
            return new List<User>();
        }

        var fileData = File.ReadAllText(_fileName);       

        var userResult = JsonConvert.DeserializeObject<List<User>>(fileData);

        return userResult;

    }

    public static void SaveData(List<User> userResult)
    {
        var jsonData = JsonConvert.SerializeObject(userResult, Formatting.Indented);

        File.WriteAllText(_fileName, jsonData);
    }
}


