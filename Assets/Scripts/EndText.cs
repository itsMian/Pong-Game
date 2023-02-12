using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndText : MonoBehaviour
{
    public Text winner;
    public Text ahihi;
    void Update()
    {
        if(GameManager.PlayerScore2 == 10)
        {
            winner.text = "Player 1 Win!";
            ahihi.text = "Player 2, Are you scared? --->";
        }
        else if(GameManager.PlayerScore1 == 10)
        {
            winner.text = "Player 2 Win!";
            ahihi.text = "Player 1, Are you scared? --->";
        }
    }
}
