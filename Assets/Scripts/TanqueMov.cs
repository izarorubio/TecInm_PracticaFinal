using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanqueMov : MonoBehaviour
{
    public float velocidad;
    public float velocidadRotacion;

    public float velocidadRotacionCabeza;
    public Transform cabezaTanque;

    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Rotación de la cabeza del tanque con Q y E
        float rotacionCabeza = 0f;
        if (Input.GetKey(KeyCode.Q))
        {
            rotacionCabeza = -velocidadRotacionCabeza * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rotacionCabeza = velocidadRotacionCabeza * Time.deltaTime;
        }

        // Aplicar rotación solo en el eje Y
        if (cabezaTanque != null)
        {
            cabezaTanque.Rotate(0, rotacionCabeza, 0);
        }

    }

    private void FixedUpdate()
    {
        // Movimiento del tanque
        float movHorizontal = Input.GetAxis("Horizontal"); // Rotación
        float movVertical = Input.GetAxis("Vertical"); // Movimiento alante y atrás

        Vector3 movimiento = transform.forward * movVertical * velocidad;
        rb.AddForce(movimiento);

        float rotacion = movHorizontal * velocidadRotacion * Time.deltaTime;
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0, rotacion, 0));

    }

}

       
