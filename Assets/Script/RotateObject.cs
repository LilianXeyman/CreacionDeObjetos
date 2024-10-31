using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(-1,0,0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(1,0,0);
        }
    }
}
