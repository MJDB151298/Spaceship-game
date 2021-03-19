using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipBehaviourScript : MonoBehaviour
{
    public GameObject soapLaser;
    public GameObject balloonSpawner;
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D trg)
    {
        if(trg.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);
            Destroy(balloonSpawner.GetComponent<BalloonSpawnerBehaviourScript>());
            gameOverCanvas.SetActive(true);
        }
    }

}
