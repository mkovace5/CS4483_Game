using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SurvivalGameOver : MonoBehaviour
{
    public string names;
    public float scores;
    public Person person;
    public Text scoreText;
    int sceneIndex;
    public InputField userName;
    public GameObject nameText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = person.dogCount.ToString();
    }

    public void SubmitButton()
    {
        scores = person.dogCount;
        names = nameText.GetComponent<Text>().text;
        PlayerPrefs.SetString("Name", names);
        Debug.Log(names);
        PlayerPrefs.SetFloat("Score", scores);

        userName.text = "";

    }
}
