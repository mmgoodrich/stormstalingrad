using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlaySkirmish() => SceneManager.LoadScene("Skirmish");
    public void PlayFinStand() => SceneManager.LoadScene("finalStand");
    public void QuitGame() => Application.Quit();
}
