using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDogs : MonoBehaviour
{
    public GameObject dogPrefab;

    // Borders
    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;

    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("Spawn", 3, 4);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //spawn dogs
    void Spawn() {
        // x position between left & right border
        int x = (int)Random.Range(borderLeft.position.x + 1,
                                borderRight.position.x -1);

        // y position between top & bottom border
        int y = (int)Random.Range(borderBottom.position.y + 1,
                                borderTop.position.y - 1);

        // Instantiate the food at (x, y)
        Instantiate(dogPrefab,
                    new Vector2(x, y),
                    dogPrefab.transform.rotation); // default rotation
    }
}
