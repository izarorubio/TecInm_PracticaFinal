using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impacto : MonoBehaviour
{

    public AudioSource audio;
    public AudioClip impacto;

    void Start()
    {
        if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            Destroy(collision.gameObject);
            FindAnyObjectByType<Marcador>().SumarPuntos();

            if (impacto != null && audio != null)
            {
                audio.PlayOneShot(impacto);
            }
        }

        StartCoroutine(Destruir3Segundos());
    }

    IEnumerator Destruir3Segundos()
    {
        yield return new WaitForSeconds(3f);

        Destroy(gameObject);
    }
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
