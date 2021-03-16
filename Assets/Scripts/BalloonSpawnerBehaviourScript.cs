using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawnerBehaviourScript : MonoBehaviour
{
    public GameObject balloon;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBalloon", 0f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBalloon(){
        Vector3 spawner = gameObject.transform.GetChild(Random.Range(0,5)).transform.position;
        //Vector3 spawnerPosition = spawner.transform.position;
        Instantiate(balloon, spawner, Quaternion.identity);
    }
}
