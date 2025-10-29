    using UnityEngine;

public class estados : MonoBehaviour
{
    public int contadorEstados = 1;
    public Animator anim;
    
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("andar", false);
        anim.SetBool("parado",  true);

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("andar", true);
            anim.SetBool("parado", false);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("andar", true);
            anim.SetBool("parado", false);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("andar", true);
            anim.SetBool("parado", false);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("andar", true);
            anim.SetBool("parado", false);
        }


        
    }
}
