using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float Velocidade = 10.0f;
    public float Corrida = 5.0f;
    private float Pulo = 15;
    private float Roll = 10.0f;
    private bool Imune = false;
    private Animator anim;

    private float girar = 60.0f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("pular", true);
            //transform.Translate(new Vector3(0, 20, 0) * Time.deltaTime * Pulo);

        }

        
    }

    void JumpOff()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("pular", false);
            transform.Translate(new Vector3(0, 10, 0) * Time.deltaTime * Pulo);
        }
    }

    void Rolar()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("rolar", true);
            //transform.Translate(new Vector3(0, 20, 0) * Time.deltaTime * Pulo);

        }

        
    }

    void RolarOff()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            anim.SetBool("rolar", false);
            //transform.Translate(new Vector3(0, 20, 0) * Time.deltaTime * Pulo);

        }
    }


    void Update()
    {
        float rotate = (Input.GetAxis("Horizontal") * girar) *Time.deltaTime;
        transform.Rotate(0, rotate, 0);

        Rolar();
        Jump();

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * Velocidade);
            anim.SetBool("andar", true);
            Jump();
            Rolar();
            JumpOff();
            RolarOff();

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * Velocidade * Corrida);
                anim.SetBool("correr", true);
                Jump();
                Rolar();
                JumpOff();
                RolarOff();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                anim.SetBool("correr", false);
                JumpOff();
                RolarOff();
            }
           
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("andar", false);
            JumpOff();
            RolarOff();

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                anim.SetBool("correr", false);
                JumpOff();
                RolarOff();
            }
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetBool("correr", false);
            JumpOff();
            RolarOff();
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * Velocidade);
            anim.SetBool("andar", true);
            Jump();
            Rolar();

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * Velocidade * Corrida);
                anim.SetBool("correr", true);
                Jump();
                Rolar();
            }
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("andar", false);
            JumpOff();
            RolarOff();
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * Velocidade);
            anim.SetBool("andar", true);
            Jump();
            Rolar();

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * Velocidade * Corrida);
                anim.SetBool("correr", true);
                Jump();
                Rolar();
            }
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("andar", false);
            JumpOff();
            RolarOff();
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * Velocidade);
            anim.SetBool("andar", true);
            Jump();
            Rolar();

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * Velocidade * Corrida);
                anim.SetBool("correr", true);
                Jump();
                Rolar();
            }
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("andar", false);
            JumpOff();
            RolarOff();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("pular", true);
            
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("pular", false);
            transform.Translate(new Vector3(0, 3, 0) * Time.deltaTime * Velocidade);
        }

        JumpOff();
        RolarOff();
    }
}
