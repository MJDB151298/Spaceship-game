using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawnerBehaviourScript : MonoBehaviour
{
    public GameObject redBalloon;
    public GameObject blueBalloon;

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
        int balloonLotto = Random.Range(1,11);
        if(balloonLotto == 4 || balloonLotto == 6){
            Instantiate(blueBalloon, spawner, Quaternion.identity);   
        }else{
            Instantiate(redBalloon, spawner, Quaternion.identity);
        }
    }
}
