using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollider : MonoBehaviour
{
    private bool playerOneFinished=false;
    private bool playerTwoFinished=false;
    [SerializeField] private HelpText helpTextOne;
    [SerializeField] private HelpText helpTextTwo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.name == "Player1"){
            Debug.Log("Wait for Player1");
            helpTextOne.Show();
            playerOneFinished=true;
            }
        if(collision.gameObject.name == "Player2"){
            Debug.Log("Wait for Player2");
            helpTextTwo.Show();
            playerTwoFinished=true;
            } 
        if(playerOneFinished && playerTwoFinished){
            Debug.Log("Game Over");
        }
    }

     private void OnTriggerLeave2D(Collider2D collision){
        if(collision.gameObject.name == "Player1"){
            playerOneFinished=false;
            }
        if(collision.gameObject.name == "Player2"){
            playerTwoFinished=false;
            } 
    }
}
