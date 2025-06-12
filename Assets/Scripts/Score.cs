using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        score = 0;
    }

    
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
