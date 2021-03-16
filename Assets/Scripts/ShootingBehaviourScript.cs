using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehaviourScript : MonoBehaviour
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
        
    }

    void OnMouseDown(){
        Vector3 shipPosition = ship.GetComponent<Transform>().position;
        Debug.Log(shipPosition);
        Instantiate(laserPrefab, shipPosition, Quaternion.identity);
    }
}
