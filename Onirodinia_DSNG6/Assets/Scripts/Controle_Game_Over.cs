using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_Game_Over : MonoBehaviour
{


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Fase_1");
        }
    }
}
