using UnityEngine;

public class movimientoitems : MonoBehaviour
{
    public Vector3 rotacionItem;
    public float velocidadRotacion;
   
    void Update()
    {
        transform.Rotate(rotacionItem * Time.deltaTime * velocidadRotacion);
    }
}
