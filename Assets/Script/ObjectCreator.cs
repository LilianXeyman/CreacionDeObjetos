using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject prebabCubeB;
    [SerializeField]
    GameObject prebabCubeR;

    GameObject objetoCreado;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Destroy(objetoCreado);
            objetoCreado = Instantiate(prebabCubeB, Vector3.zero, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(objetoCreado);
            objetoCreado = Instantiate(prebabCubeR, Vector3.zero, Quaternion.identity);
        }

        objetoCreado.SetActive(false);//Desactivas el objeto para que no choque el rayo con el objeto y lo mueva si no que sea un efecto de follow
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 hitPoint = new Vector3(hit.point.x,hit.point.y + 0.5f ,hit.point.z);
            objetoCreado.transform.position = hitPoint;
        }
        objetoCreado.SetActive(true);//Lo vuelves a activar para poder ir moviendolo
       /* Vector3 rayPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(rayPosition);
        Debug.Log("Posicion en pantalla =" + Input.mousePosition + " pos world " + worldPosition);
        objetoCreado.transform.position = worldPosition;*/
    }
}
