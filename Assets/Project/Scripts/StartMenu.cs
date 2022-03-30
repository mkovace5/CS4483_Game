using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject helpUI;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuUI.SetActive(true);
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
}
