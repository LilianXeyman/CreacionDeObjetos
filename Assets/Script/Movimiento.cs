using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Este Script le conferira a los cubos el movimiento contrario a cada uno. El rojo será el que mantenga los controles normales (AWSD) y el azul los controles invertidos.
    //Variables de movimiento
    [SerializeField]
    float movX;
    [SerializeField]
    float movY;
    [SerializeField]
    float movZ;
    [SerializeField]
    float velJugador=2.5f;
    [SerializeField]
    bool invertedAxes;

    private void Awake()
    {
        if (invertedAxes == true)
        {
            velJugador = velJugador * -1;
        }
    }
    void Update()
    {
        //Puedes dejarlo con estas tres primeras lineas poner los ejes en local y rotar el cubo. En principio habría que buscar otra forma
        movX = -Input.GetAxis("Vertical")*velJugador*Time.deltaTime;
        movZ = Input.GetAxis("Horizontal")*velJugador*Time.deltaTime;
        transform.Translate(movX, movY, movZ);

    }
}
