using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
        GameManager.ResetPoint();
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        GameManager.ResetPoint();
    }
}
