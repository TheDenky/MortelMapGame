using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaLograda : MonoBehaviour
{
    public GameObject objetivoCanvas;
    public GameObject musica;
    private AudioSource musiquita;
    public bool win;
    // Start is called before the first frame update
    void Start()
    {
        objetivoCanvas.SetActive(false);
        musiquita = musica.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(win)
        {
            Time.timeScale = 0f;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            objetivoCanvas.SetActive(true); 
            win = true;
            musiquita.enabled = false;
        }
    }
}
