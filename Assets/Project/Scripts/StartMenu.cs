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

    public void GoToMain(){
        helpUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

    public void GoToHelp(){
        helpUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void GoToSurvival(){
        SceneManager.LoadScene("SurvivalMode");
    }
}
