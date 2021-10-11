using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cargaNivel(string pNombreNivel){
        SceneManager.LoadScene(pNombreNivel);
    }
    public void salir(){
        Application.Quit();
        Debug.Log("Se ha salido del juego");
    }
}
