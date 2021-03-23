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
    public int maxHealth;
    public int currentHealth;
    public HealthScript healthBar;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 50;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        StartCoroutine(TenSecondsDamage());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TakeDamage()
    {
        currentHealth -= 10;
        healthBar.SetHealth(currentHealth);
        if(currentHealth == 0)
        {
            gotGameOver();
        }
        StartCoroutine(TenSecondsDamage());
    }

    IEnumerator TenSecondsDamage()
    {
        yield return new WaitForSeconds(10f);
        TakeDamage();
    }

    void OnTriggerEnter2D(Collider2D trg)
    {
        if(trg.gameObject.tag == "Destroyer")
        {
            //Cambiando el texto del canvas
            gotGameOver();
        }
    }

    public void IncreaseHealth(int health)
    {
        currentHealth += health;
        healthBar.SetHealth(currentHealth);
    }

    public void gotGameOver()
    {
        healthBar.SetHealth(0);
        Destroy(gameObject);
        Destroy(balloonSpawner.GetComponent<BalloonSpawnerBehaviourScript>());

        gameOverText.text = "GAME OVER";
        gameOverButton.text = "RETRY";
        gameOverCanvas.SetActive(true);
    }

}
