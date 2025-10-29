using UnityEngine;

public class camara : MonoBehaviour
{
    public Vector3 distanciaRelativa;


    void Update()
    {
        transform.position = GameObject.Find("jugador").transform.position + distanciaRelativa;
    }


}