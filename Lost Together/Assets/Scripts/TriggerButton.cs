using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    public GameObject playerCollider;

    [SerializeField] private ISwitchable client;
    [SerializeField] private bool isDoorOpenSwitch;
    [SerializeField] private bool isDoorCloseSwitch;

    private float switchSizeY;
    private Vector3 switchUpPos;
    private Vector3 switchDownPos;
    private float switchSpeed=1f;
    private float switchDelay=0.2f;
    private bool isPressingSwitch = false;


    void Awake(){
        switchSizeY=transform.localScale.y / 10;
        switchUpPos=transform.position;
        switchDownPos=new Vector3(transform.position.x,transform.position.y-switchSizeY,transform.position.z);
    }

    void Update(){
        if(isPressingSwitch){
            MoveSwitchDown();
        }
        else if(!isPressingSwitch){
            MoveSwitchUp();
        }
    }

    void MoveSwitchDown(){
        if(transform.position!=switchDownPos){
            transform.position=Vector3.MoveTowards(transform.position, switchDownPos,switchSpeed*Time.deltaTime);
        Debug.Log(isPressingSwitch);


        }
    }

      void MoveSwitchUp(){
        if(transform.position!=switchUpPos){
            transform.position=Vector3.MoveTowards(transform.position, switchUpPos,switchSpeed*Time.deltaTime);
        Debug.Log(isPressingSwitch);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.gameObject == playerCollider){
            isPressingSwitch=true;
                client.Activate();
            }
        }

      private void OnTriggerStay2D(Collider2D collision){

        if(collision.gameObject == playerCollider){
            isPressingSwitch=true;
            // if(isDoorOpenSwitch && !client.IsActive()){
            //     client.Deactivate();
            // }
            // else if(isDoorCloseSwitch && client.IsActive()){
            //     client.Activate();
            // }

            }
        }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject == playerCollider){
            StartCoroutine(SwitchUpDelay(switchDelay));
        }
    }

    IEnumerator SwitchUpDelay(float waitTime){
        yield return new WaitForSeconds(waitTime);
        isPressingSwitch=false;
        client.Deactivate();
    }
}

