using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao_iniciar : MonoBehaviour
{
    public void IniciarFase1(){ 
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase_1");
    }    
}
