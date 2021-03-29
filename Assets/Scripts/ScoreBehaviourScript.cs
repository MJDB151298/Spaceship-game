using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreBehaviourScript : MonoBehaviour
{
    private int score;
    public GameObject gameOverCanvas;
    public GameObject ship;
    public GameObject balloonSpawner;
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

    public void UpdateScore(int points){
        this.score += points;
        gameObject.GetComponent<Text>().text = this.score.ToString().PadLeft(3, '0');
        if(score >= 500){
            Destroy(ship);
            Destroy(balloonSpawner.GetComponent<BalloonSpawnerBehaviourScript>());
            gameOverText.text = "GOOD WORK!";
            gameOverButton.text = "NEXT";
            gameOverCanvas.SetActive(true);
        }
    }

    public void ResetScore(){
        this.score = 0;
        gameObject.GetComponent<Text>().text = "000";
    }
}
