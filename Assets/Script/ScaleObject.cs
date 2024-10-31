using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    // En este Script se hará que a medida que se gire la rueda del raton el objeto que tenga el Script se escale
    // Update is called once per frame
    void Update()
    {
        Vector3 newScale = transform.localScale;
        newScale += Input.mouseScrollDelta.y * Vector3.one;
        transform.localScale = newScale;
        /* if (Input.mouseScrollDelta.y)
        {
            gameObject.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        }*/
    }
}
