using UnityEngine;
using TMPro;

public class movimientos : MonoBehaviour

{
    public TextMeshProUGUI textoContador;
    public TextMeshProUGUI mensajeFinal;
    public int contador=0;
    public int vida = 10;
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;
    public Rigidbody rb;
    public bool enSuelo = true;
    public float sensibilidadRaton = 10f;
    
    private void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("item"))
    {
        Destroy(other.gameObject);

        contador++;

        textoContador.text = "Items: " + contador;
    }
}

    void Start()
    {
        Debug.Log("El juego comienza");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 5 * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 5 * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && enSuelo == true)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            enSuelo = false; //evita saltar de nuevo hasta tocar el suelo
        }

        float moveX = Input.GetAxis("Mouse X");
        transform.Rotate(0, moveX * sensibilidadRaton, 0);

        if (contador >= 2)
        {
            mensajeFinal.gameObject.SetActive(true);
        }
    }

    //DETECTAR COLISIÓN DE SUELO
    void OnCollisionEnter(Collision collision)
    {
        //Detecta si colisiona con el suelo
        if (collision.gameObject.CompareTag("suelo"))
        {
            enSuelo = true;
        }
    }

    void OnCollisionExit(Collision collision) //detectactar cuando termina la colision
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            enSuelo = false;
        }
    }


}

