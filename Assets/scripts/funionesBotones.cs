using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funionesBotones : MonoBehaviour
{
    public void botonpresionado(GameObject personaje){

        personaje.GetComponent<AudioSource>().clip = personaje.GetComponent<personaje>().audiopersonaje2;
        personaje.GetComponent<AudioSource>().Play();
        GameObject.FindGameObjectWithTag("segundocanvas").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("primercanvas").GetComponent<Canvas>().enabled = false;
    }
}
