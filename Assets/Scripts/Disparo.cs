using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public float velocidad;
    public Transform BalaAparece;
    public GameObject balaPrefab;
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparar();
        }
        
    }

    private void Disparar()
    {
        GameObject bala = Instantiate(balaPrefab, BalaAparece.position, BalaAparece.rotation);
        Rigidbody balaRb = bala.GetComponent<Rigidbody>();
        balaRb.AddForce(bala.transform.forward * velocidad);

    }
}
