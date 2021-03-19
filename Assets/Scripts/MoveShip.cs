using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public GameObject spaceShip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spaceShip != null)
        {
            var pos = spaceShip.transform.position;
            pos.y -= 0.02f;
            spaceShip.transform.position = pos;
        }
    }

    void OnMouseDown()
    {
        if (spaceShip != null)
        {
            var pos = spaceShip.transform.position;
            pos.y += 1f;
            spaceShip.transform.position = pos;
        }
    }
}
