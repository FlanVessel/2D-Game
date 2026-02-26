using UnityEngine;
using System;

public class TimerManager : MonoBehaviour
{
    public float duration = 10f;
    float timeLeft;

    public Action OnTimeEnd;

    public void StartTimer()
    {
        timeLeft = duration;
        enabled = true;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if(timeLeft <= 0)
        {
            timeLeft = 0;
            enabled = false;
            OnTimeEnd?.Invoke();
        }
    }

    public float GetTimeLeft() => timeLeft;
}