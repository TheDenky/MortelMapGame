using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour
{
    Puntaje puntaje;
    public float puntosMax;
    public int cambiarAEscena;
    public GameObject puntajePantalla;

    // Start is called before the first frame update
    void Start()
    {
        //puntaje = GetComponent<Puntaje>();
    }

    // Update is called once per frame
    //void Update()
    //{
     //   puntaje = GetComponent<Puntaje>();
     //   if(puntosMax == puntaje.valor){
     //       SceneManager.LoadScene(cambiarAEscena);
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            SceneManager.LoadScene("SampleScene");
        }
    }
}
