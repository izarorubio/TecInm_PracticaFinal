using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impacto : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            Destroy(collision.gameObject);
        }

        StartCoroutine(Destruir3Segundos());
    }

    IEnumerator Destruir3Segundos()
    {
        yield return new WaitForSeconds(3f);

        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
