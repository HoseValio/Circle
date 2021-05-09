using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [Header("Score UI text")]
    public Text text;
    
    [SerializeField]
    private int score = 0;

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int value)
    {
        score = value;
        text.text = score.ToString();
    }

    public void Increase(int factor = 1)
    {
        score += factor;
        text.text = score.ToString();
    }
}
