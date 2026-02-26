using UnityEngine;
using System.IO;

public class SaveSystem
{
    string path => Application.persistentDataPath + "/profiles.json";

    public void Save(ProfileList list)
    {
        string json = JsonUtility.ToJson(list,true);
        File.WriteAllText(path,json);
    }

    public ProfileList Load()
    {
        if(!File.Exists(path))
            return new ProfileList();

        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<ProfileList>(json);
    }
}