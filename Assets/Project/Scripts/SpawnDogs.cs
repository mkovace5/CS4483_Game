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
    public Collider2D[] colliders;
    public float radius = 10f;


    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    //spawn dogs
    public void Spawn() {
        bool canSpawnHere = false;

        Vector3 newSpawnPos = new Vector3(0,0,0);
        int safetyNet = 0;

        while(!canSpawnHere){
            int x = (int)Random.Range(borderLeft.position.x + 1, borderRight.position.x - 1);
            int y = (int)Random.Range(borderBottom.position.y + 1, borderTop.position.y - 1);
            
            newSpawnPos = new Vector3(x, y, 0);
            canSpawnHere = PreventSpawnOverlap(newSpawnPos);

            safetyNet++;

            if(safetyNet > 50){
                break;
            }
        }
        Instantiate(dogPrefab, newSpawnPos, dogPrefab.transform.rotation); // default rotation
    }

    // Update is called once per frame
    bool PreventSpawnOverlap(Vector3 spawnPos)
    {
        colliders = Physics2D.OverlapCircleAll(transform.position, radius);

        for(int i=0; i< colliders.Length; i++){
            Vector3 centerPoint = colliders [i].bounds.center;
            float width = colliders [i].bounds.extents.x;
            float height = colliders [i].bounds.extents.y;

            float leftExtent = centerPoint.x - width;
            float rightExtent = centerPoint.x + width;
            float lowerExtent = centerPoint.y - height;
            float upperExtent = centerPoint.y + height;

            if(spawnPos.x >= leftExtent && spawnPos.x <= rightExtent){
                if(spawnPos.y >= lowerExtent && spawnPos.y <= upperExtent){
                    return false;
                }
            }
        }
        return true;
    }
}
