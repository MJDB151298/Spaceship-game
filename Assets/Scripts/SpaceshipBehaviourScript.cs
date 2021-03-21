using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceshipBehaviourScript : MonoBehaviour
{
    public GameObject soapLaser;
    public GameObject balloonSpawner;
    public GameObject gameOverCanvas;
    public TMP_Text gameOverText;
    public TMP_Text gameOverButton;

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

            //Cambiando el texto del canvas
            gameOverText.text = "GAME OVER";
            gameOverButton.text = "RETRY";
            gameOverCanvas.SetActive(true);
        }
    }

}
