using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorColisao : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private float Velocidade = 8;
    private float Corrida = 8;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Parede")
        {
            //rb.AddForce(Vector3.back * 100);
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0, 0, -2) * Time.deltaTime * Velocidade);

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.Translate(new Vector3(0, 0, -2) * Time.deltaTime * Velocidade * Corrida);

                }
             }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(2, 0, 0) * Time.deltaTime * Velocidade);

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.Translate(new Vector3(2, 0, 0) * Time.deltaTime * Velocidade * Corrida);

                }
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(-2, 0, 0) * Time.deltaTime * Velocidade);

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.Translate(new Vector3(-2, 0, 0) * Time.deltaTime * Velocidade * Corrida);

                }
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, 0, 2) * Time.deltaTime * Velocidade);

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.Translate(new Vector3(0, 0, 2) * Time.deltaTime * Velocidade * Corrida);

                }
            }

        }
    }

    
}
