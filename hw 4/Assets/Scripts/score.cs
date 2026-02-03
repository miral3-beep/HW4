using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
   public static score instance; 
    [SerializeField] private TextMeshProUGUI _currentScoreText;

    private int _score;
   private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        _currentScoreText.text = "0";
    }
    private void OnEnable()
    {
        GameEvents.OnScoreChanged += UpdateScoreText;
    }
    private void OnDisable()
    {
        GameEvents.OnScoreChanged -= UpdateScoreText;
    }
   

    public void UpdateScore()
    {
        _score++;
        GameEvents.RaiseScoreChanged(_score);

    }
    public void UpdateScoreText(int newScore)
    {
        _currentScoreText.text = newScore.ToString();
    }
}
