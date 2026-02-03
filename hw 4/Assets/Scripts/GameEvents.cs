using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public static class GameEvents
{
    public static event Action<int> OnScoreChanged;
    public static event Action OnGameOver;

    public static void RaiseScoreChanged(int newScore)
    {
        OnScoreChanged?.Invoke(newScore);
    }

    public static void RaiseGameOver()
    {
        OnGameOver?.Invoke();
    }
}
