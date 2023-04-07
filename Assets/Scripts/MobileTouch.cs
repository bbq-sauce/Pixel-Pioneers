using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MobileTouch : MonoBehaviour
{
    //public CharacterController characterController;
    //public Joystick Joystick;
    public float movespeed = 1;
    // public Rigidbody2D rigidbody2D;
    //public Animator animator;

    float hInput;
    //public float horizontal = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


        // horizontal = Joystick.Horizontal * moveSpeed;
        /*if(Joystick.>= .2f)
         {
             horizontal = moveSpeed;

         }
        else if(Joystick.Horizontal <= -.2f)
         {
             horizontal -= moveSpeed;

         }
         else
         {
             horizontal= 0;  
         }
         
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;

        }

        hInput = Input.GetAxis("Horizontal");
        transform.position = new Vector2(Mathf.Clamp(transform.position.x + hInput * moveSpeed, -2f, 2f), transform.position.y);*/

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x < Barrier.rightSide)
            {
                transform.Translate(Vector2.left * Time.deltaTime * movespeed);
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //if (this.gameObject.transform.position.x > Barrier.leftSide)
            //{
                transform.Translate(Vector2.left * Time.deltaTime * movespeed*-1 );
            //}
        }
    }


}
