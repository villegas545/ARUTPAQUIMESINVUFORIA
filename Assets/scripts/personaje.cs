using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip audiopersonaje,audiopersonaje2;

    private bool bandera = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<=0){
            if(bandera==false){
                bandera = true;
                Debug.Log("hola"); 
                GetComponent<AudioSource>().clip = audiopersonaje;
                GetComponent<AudioSource>().Play();
                GetComponent<Animator>().SetTrigger("hablar");
            }
        }else{
            transform.position = new Vector3(transform.position.x, (transform.position.y-.3f), transform.position.z);
        }
    }
}
