using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    void Update()
    {
        if(gameObject.name == "Player1Score")
            scoreText.text = GameManager.PlayerScore2.ToString();
        else
            scoreText.text = GameManager.PlayerScore1.ToString();
    }
}
