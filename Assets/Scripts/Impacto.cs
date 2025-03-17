using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impacto : MonoBehaviour
{

    public AudioSource audio;
    public AudioClip impacto;

    void Start()
    {
        // Si no se ha asignado una fuente de audio en el Inspector, intenta obtenerla (por si acaso)
        if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }

    }
    private void OnCollisionEnter(Collision collision)
    {

        // Si la bala colisiona con un objeto taggeado "Pared"...
        if (collision.gameObject.CompareTag("Pared"))
        {
            Destroy(collision.gameObject); // Destruir la pared
            FindAnyObjectByType<Marcador>().SumarPuntos(); // Sumar puntos en el marcador

            // Si está asignado reproduce el sonido
            if (impacto != null && audio != null)
            {
                audio.PlayOneShot(impacto);
            }

        }

        // Inicia la corutina
        StartCoroutine(Destruir3Segundos());
    }

    // Corutina para destruir la bala después de 3''
    IEnumerator Destruir3Segundos()
    {
        yield return new WaitForSeconds(3f);

        Destroy(gameObject);
    }
  
}
