using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject helpUI;
    int levelPassed;
    public Button survivalBtn;
    public Text survivalTxt;
    public GameObject survivalUI;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuUI.SetActive(true);
        levelPassed = PlayerPrefs.GetInt("LevelPassed"); 

        if(levelPassed == 15){
            survivalBtn.interactable = true;
            survivalTxt.color = Color.black;
        }
    }

    public void GoToLevels(){
        SceneManager.LoadScene("Levels");
    }

    public void GoToSettings(){
        SceneManager.LoadScene("Settings");
    }

    public void GoToMain(){
        helpUI.SetActive(false);
        survivalUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

    public void GoToHelp(){
        helpUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void GoToSurvival(){
        mainMenuUI.SetActive(false);
        survivalUI.SetActive(true);
    }

    public void StartSurvival(){
        SceneManager.LoadScene("Survival Game");
    }
}
