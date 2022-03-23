using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject levelsUI;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
        levelsUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {   
        Global.isGamePaused = true;
        Time.timeScale = 0f;
        Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
    }

    public void Resume()
    {
        Global.isGamePaused = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void QuitGame()
    {
        Global.isGamePaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScreen");        
    }

    public void goBack(){
        levelsUI.SetActive(true);
        Global.isGamePaused = false;
        Time.timeScale = 1f;
    }
    public void loadLevel1(){
        levelsUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
