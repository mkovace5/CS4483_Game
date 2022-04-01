using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text dogText;
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
        if(sceneIndex == 17){
            dogText.text = "Dogs Caught: " + person.dogCount;
        }else{
            dogText.text = "Dogs Left: " + person.dogCount;
        }
    }
}
