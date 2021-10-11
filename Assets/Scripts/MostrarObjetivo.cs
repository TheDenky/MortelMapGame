using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MostrarObjetivo : MonoBehaviour
{
    public GameObject objetivoCanvas;
    // Start is called before the first frame update
    void Start()
    {
        objetivoCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //objetivoCanvas.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            objetivoCanvas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            objetivoCanvas.SetActive(false);
        }
    }
}
