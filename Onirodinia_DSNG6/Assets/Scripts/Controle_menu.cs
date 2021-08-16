using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_menu : MonoBehaviour
{
    public GameObject menu;
    private bool estadoMenu;

    public void IniciarFase1(){ 
        UnityEngine.SceneManagement.SceneManager.LoadScene("CutScene1");
    }

    public void FecharJogo()
    {
        Application.Quit();
    } 

    public void BarraMenu()
    {
        if(!estadoMenu){
            menu.SetActive(true);
            estadoMenu = true;
        }
        else{
            menu.SetActive(false);
            estadoMenu = false;
        }
    }
}
