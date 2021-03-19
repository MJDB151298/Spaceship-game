using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehaviourScript : MonoBehaviour
{
    public GameObject shootButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Este script estaria atado al boton de disparar y al laser, confirmamos que el gameobject
        //sea el laser y lo movemos continuamente hasta que alcanze una posicion en pantalla para destruirlo
        transform.Translate(Vector3.left * 10 * Time.deltaTime);
        if(gameObject.GetComponent<Transform>().position.x < -14){
            Debug.Log(gameObject.name);
            Destroy(gameObject);
            DecreaceLaserCount();
        }  
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.tag == "Balloon"){
            Destroy(gameObject);
            Destroy(collider.gameObject);
            DecreaceLaserCount();
        }
    }

    void DecreaceLaserCount()
    {
        GameObject shootButton = GameObject.Find("shoot-button");
        shootButton.GetComponent<ShootingBehaviourScript>().laserCount -= 1;
    }
}
