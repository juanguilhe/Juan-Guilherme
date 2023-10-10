using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float sensibilidade = 100f;

    public Transform bodyPlayer;

    float xRotacao = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;

        xRotacao -= mouseY;
        xRotacao = Mathf.Clamp(xRotacao, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotacao, 0f, 0f);
        bodyPlayer.Rotate(Vector3.up * mouseX);
    }
}
