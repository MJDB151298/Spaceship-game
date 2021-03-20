using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuOptionsScript : MonoBehaviour
{
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RetryClicked()
    {
        SceneManager.LoadScene("SampleScene");

        //Reiniciando la puntuacion
        scoreText.GetComponent<ScoreBehaviourScript>().ResetScore();
    }
}
