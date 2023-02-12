using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;
    GameObject theBall;

    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }

    public static void Score(string wallID)
    {
        if (wallID == "Player1Goal")
            PlayerScore1++;
        else if (wallID == "Player2Goal")
            PlayerScore2++;
    }

    public static void ResetPoint()
    {
        GameManager.PlayerScore1 = 0;
        GameManager.PlayerScore2 = 0;
    }
    
    static void Winner()
    {
        if(PlayerScore1 == 10 || PlayerScore2 == 10)
        {
            SceneManager.LoadScene(3);
        }
    }
    private void Update()
    {
        Winner();
    }
    
}
