using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public GameObject winScreenUI;
    public Person person;
    int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene ().buildIndex;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextLevel(){
		SceneManager.LoadScene (sceneIndex + 1);
        Time.timeScale = 1f;
    }
}
