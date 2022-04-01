using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsScript : MonoBehaviour
{
    public Button level2, level3, level4, level5, level6, level7, level8, level9, level10, level11, level12, level13, level14, level15;
    int levelPassed;
    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed"); 
        
        switch (levelPassed)
        {
            case 1:
                level2.interactable = true;
                break;
            case 2:
                level2.interactable = true;
                level3.interactable = true;
                break;
            case 3:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                break;
            case 4:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                break;
            case 5:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                break;
            case 6:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                break;
            case 7:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                level8.interactable = true;
                break;
            case 8:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                level8.interactable = true;
                level8.interactable = true;
                break;
            case 9:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                level8.interactable = true;
                level9.interactable = true;
                level10.interactable = true;
                break;
            case 10:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                level8.interactable = true;
                level9.interactable = true;
                level10.interactable = true;
                level11.interactable = true;
                break;
            case 11:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                level8.interactable = true;
                level9.interactable = true;
                level10.interactable = true;
                level11.interactable = true;
                level12.interactable = true;
                break;
            case 12:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                level8.interactable = true;
                level9.interactable = true;
                level10.interactable = true;
                level11.interactable = true;
                level12.interactable = true;
                level13.interactable = true;
                break;
            case 13:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                level8.interactable = true;
                level9.interactable = true;
                level10.interactable = true;
                level11.interactable = true;
                level12.interactable = true;
                level13.interactable = true;
                level14.interactable = true;
                break;
            case 14:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                level8.interactable = true;
                level9.interactable = true;
                level10.interactable = true;
                level11.interactable = true;
                level12.interactable = true;
                level13.interactable = true;
                level14.interactable = true;
                level15.interactable = true;
                break;
            default:
                break;
        }      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelToLoad(int level)
    {
        SceneManager.LoadScene("Game "+ level);
        Global.isGamePaused = false;
    }
    
    public void GoToStart()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
