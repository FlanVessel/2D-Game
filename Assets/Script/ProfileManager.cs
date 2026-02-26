using UnityEngine;

public class ProfileManager : MonoBehaviour
{
    public Profile CurrentProfile { get; private set; }

    ProfileList profiles;
    SaveSystem save;

    void Awake()
    {
        save = new SaveSystem();
        profiles = save.Load();
    }

    public void CreateProfile(string name)
    {
        Profile p = new Profile();
        p.playerName = name;
        profiles.profiles.Add(p);
        CurrentProfile = p;
        save.Save(profiles);
    }

    public void SelectProfile(Profile p)
    {
        CurrentProfile = p;
    }

    public void AddScore(int score)
    {
        if (CurrentProfile == null)
        {
            Debug.LogWarning("No hay perfil activo. Score no guardado.");
            return;
        }

        CurrentProfile.scores.Add(score);
        save.Save(profiles);
    }

    public ProfileList GetProfiles() => profiles;
}