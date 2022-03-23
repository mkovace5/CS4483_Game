using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject levelsUI;
    public GameObject mainMenuUI;
    public GameObject helpUI;

    // Start is called before the first frame update
    void Start()
    {
        levelsUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

     public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Global.isGamePaused = false;
    }

    public void GoToLevels(){
        levelsUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void GoToMain(){
        helpUI.SetActive(false);
        levelsUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

    public void GoToHelp(){
        helpUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }
}
