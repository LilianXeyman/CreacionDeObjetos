using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenScale : MonoBehaviour
{
    // En este Script se hará que a medida que se gire la rueda del raton el objeto que tenga el Script se escale usando LeanTween. REVISAR
    [SerializeField]
    float tiempoAnim;
    [SerializeField]
    LeanTweenType animCurv;
    [SerializeField]
    float size = 1f;
    float newScale;
    void Awake()
    {
        size = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        newScale += Input.mouseScrollDelta.y * size;
        LeanTween.scale(gameObject, new Vector3 (newScale, newScale, newScale),tiempoAnim).setEase(animCurv);
    }
}
