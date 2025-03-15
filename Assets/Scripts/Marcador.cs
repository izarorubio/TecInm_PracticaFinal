using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Marcador : MonoBehaviour
{
    public TMP_Text marcadorText;
    public TMP_Text puntosText;
    private int puntos = 0;
    private int totalPuntos = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SumarPuntos()
    {
        puntos++;
        puntosText.text = puntos.ToString();
        
        if (puntos == totalPuntos)
        {
            Destroy(puntosText.gameObject);
            marcadorText.text = "Juego Terminado";
        }
    }
}
