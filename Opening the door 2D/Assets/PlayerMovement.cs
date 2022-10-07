using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5.0f;
    private Rigidbody rbody;
    // Start is called before the first frame update
    void Start ()
    {
        rbody=GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update(){   
        Move();
    }
    private void Move(){
           float horizontalVector = Input.GetAxis("Horizontal");
           float verticalVector = Input.GetAxis("Vertical");
           Vector2 playerVelocity = new Vector2(horizontalVector*movementSpeed, verticalVector*movementSpeed);
           rbody.velocity = playerVelocity;
    }
              
}
