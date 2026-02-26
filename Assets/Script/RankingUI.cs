using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class RankingUI : MonoBehaviour
{
    public TMP_Text text;

    public void Show(ProfileList profiles)
    {
        List<(string,int)> allScores = new();

        foreach(var p in profiles.profiles)
            foreach(var s in p.scores)
                allScores.Add((p.playerName,s));

        allScores.Sort((a,b)=> b.Item2.CompareTo(a.Item2));

        string t = "RANKING\n\n";

        foreach(var s in allScores)
            t += s.Item1 + " - " + s.Item2 + "\n";

        text.text = t;
    }
}