using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject Door ;
    bool isOpened=false;

    void OnTriggerEnter(Collider col){
        if (!isOpened){
            isOpened=true;
            Door.transform.position+=new Vector3(-4,0,0);
            StartCoroutine(Close());           
        }
    } 
    IEnumerator Close(){
        if(Door.transform.position.x==-4){
            yield return new WaitForSeconds(2);
            Door.transform.position+=new Vector3(4,0,0);
            isOpened=false;
        }                              
    }
        
}
