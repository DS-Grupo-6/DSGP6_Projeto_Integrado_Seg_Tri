using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Damage : MonoBehaviour
{
 
    private Helena player;

    void Awake() {
        player = GameObject.Find("Helena").GetComponent<Helena> ();
    }

    void OnTriggerEnter2D(Collider2D other) {

        if(other.CompareTag ("Object_Damage")){//Para os objetos que forem de dano lembrar de mudar a tag deles
            if (!player.invunerable){
                player.DamagePlayer ();
            }
        }
            
     }
}
