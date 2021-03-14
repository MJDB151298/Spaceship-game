using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehaviourScript : MonoBehaviour
{
    public GameObject ship;
    public GameObject laserPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Este script estaria atado al boton de disparar y al laser, confirmamos que el gameobject
        //sea el laser y lo movemos continuamente hasta que alcanze una posicion en pantalla para destruirlo
        if(gameObject.name == "soap laser(Clone)"){
            transform.Translate(Vector3.left * 10 * Time.deltaTime);
            if(gameObject.GetComponent<Transform>().position.x < -14){
                Debug.Log(gameObject.name);
                Destroy(gameObject);
            }
        }   
    }

    //TODO: hacer que no aparezcan tantos jabones juntos
    void OnMouseDown(){
        if(gameObject.name == "shoot-button"){
            Vector3 shipPosition = ship.GetComponent<Transform>().position;
            Debug.Log(shipPosition);
            Instantiate(laserPrefab, shipPosition, Quaternion.identity);
        } 
    }
}
