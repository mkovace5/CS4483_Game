using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class Person : MonoBehaviour
{
    Vector2 dir = Vector2.right;
    public GameObject gameOverUI;
    public GameObject winScreenUI;
    public float speed;
    public SpawnDogs spawnDogs;
    public static bool GameIsOver = false;
    public int initialDogs = 5;
    public int dogCount;
    public AudioSource sound;
    private Rect audiorect;
    public AudioClip bark;
    int sceneIndex, levelPassed;

    bool ate = false;

    // Tail Prefab
    public GameObject tailPrefab;

    List<Transform> dog = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Move", speed, speed); 
        gameOverUI.SetActive(false);   
        dogCount = initialDogs;
        GetComponent<AudioSource> ().clip = bark;
        sceneIndex = SceneManager.GetActiveScene ().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed"); 
    }

    // Update is called once per frame
    void Update()
    {
        // Move in a new Direction?
        if (Input.GetKey(KeyCode.RightArrow))
            dir = Vector2.right;
        else if (Input.GetKey(KeyCode.DownArrow))
            dir = -Vector2.up;    // '-up' means 'down'
        else if (Input.GetKey(KeyCode.LeftArrow))
            dir = -Vector2.right; // '-right' means 'left'
        else if (Input.GetKey(KeyCode.UpArrow))
            dir = Vector2.up;
    }

    void Move() {
        // Save current position (gap will be here)
        Vector2 v = transform.position;

        // Move person into new direction (now there is a gap)
        transform.Translate(dir);

        // Ate something? Then insert new Element into gap
        if (ate) {
            sound.Play();

            // Load Prefab into the world
            GameObject g =(GameObject)Instantiate(tailPrefab, v, tailPrefab.transform.rotation);

            dog.Insert(0, g.transform);

            // Reset the flag
            ate = false;
        }

        // Do we have a dog?
        if (dog.Count > 0) {
            // Move last dog Element to where the Head was
            dog.Last().position = v;

            // Add to front of list, remove from the back
            dog.Insert(0, dog.Last());
            dog.RemoveAt(dog.Count-1);
        }
    }

    void OnTriggerEnter(Collider coll) {
        if (coll.name.StartsWith("DogPrefab")) {
            // Get longer in next Move call
            ate = true;

            if(sceneIndex == 17){
                dogCount++;
            }else{
                dogCount--;        
            }
            // Remove the Food
            Destroy(coll.gameObject);
            GetComponent<AudioSource> ().Play ();

            if(dogCount == 0 && sceneIndex!=17){
                YouWin();
            }            

            spawnDogs.Spawn();

        }
        // Collided with Tail or Border
        else {
            Global.isGameOver = true;
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void YouWin(){
        Time.timeScale = 0f;
        winScreenUI.SetActive(true);

        if (sceneIndex == 17)
            //TODO: make You Win screen that directs you back to main menu
			// Invoke ("loadMainMenu", 1f);
            return;
		else {
			if (levelPassed < (sceneIndex-1))
				PlayerPrefs.SetInt ("LevelPassed", (sceneIndex-1));
		    }
    }
}
