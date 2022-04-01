using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{

    public Text scoreText;
   

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "DOGS CAUGHT: " + GameObject.Find("Person").GetComponent<PersonSurvival>().dogCount.ToString();
    }
}
