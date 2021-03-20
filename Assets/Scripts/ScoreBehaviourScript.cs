using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehaviourScript : MonoBehaviour
{
    private int score;
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
    }

    public void ResetScore(){
        this.score = 0;
        gameObject.GetComponent<Text>().text = "000";
    }
}
