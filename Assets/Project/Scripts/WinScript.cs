using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public GameObject winScreenUI;
    public GameObject comingSoonUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextLevel(){
        comingSoonUI.SetActive(true);
        winScreenUI.SetActive(false);
    }
}
