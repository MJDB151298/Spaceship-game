using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehaviourScript : MonoBehaviour
{
    public GameObject ship;
    public GameObject laserPrefab;
    public int laserCount;


    // Start is called before the first frame update
    void Start()
    {
        laserCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        if(ship != null && laserCount < 3)
        {
            Vector3 shipPosition = ship.GetComponent<Transform>().position;
            Debug.Log(shipPosition);
            Instantiate(laserPrefab, shipPosition, Quaternion.identity);
            laserCount++;
        }
    }
}
