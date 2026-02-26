using System.Collections.Generic;

[System.Serializable]
public class Profile
{
    public string playerName;
    public List<int> scores = new List<int>();
}

[System.Serializable]
public class ProfileList
{
    public List<Profile> profiles = new List<Profile>();
}
