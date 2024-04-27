using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        // if(collision.gameObject.name == "Player1"){
        //     Debug.Log("Wait for Player2");
        //     }
        // if(collision.gameObject.name == "Player2"){
        //     Debug.Log("Wait for Player1");
        //     }

        if(collision.gameObject.name == "Player1" && collision.gameObject.name == "Player2"){
            Debug.Log(collision.gameObject.name);
            }
        
    }

     private void OnTriggerEnter2D(Collider2D collision){
        // if(collision.gameObject.name == "Player1"){
        //     Debug.Log("Wait for Player2");
        //     }
        // if(collision.gameObject.name == "Player2"){
        //     Debug.Log("Wait for Player1");
        //     }

        if(collision.gameObject.name == "Player1" && collision.gameObject.name == "Player2"){
            Debug.Log(collision.gameObject.name);
            }
        
    }
}
