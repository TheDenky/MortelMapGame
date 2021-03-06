using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public bool IsPaused;
    public GameObject PauseMenu;

    // Update is called once per frame
    void Update()
    {
        if(IsPaused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }else {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
        }
    }
    public void Resume()
    {
        IsPaused     = !IsPaused;
    }
    public void Menu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuInicio");
    }
    public void salir(){
        Application.Quit();
        Debug.Log("Se ha salido del juego");
    }
}
