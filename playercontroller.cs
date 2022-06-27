using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
     Rigidbody rb;
     public CharacterController cont;
     private float speed;
     private float xmove;
     private bool isJumping = false;
     private bool grounded = true;

     private float ymove;

     private float jforce = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cont = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        xmove = Input.GetAxisRaw("Horizontal");
    }

         void FixedUpdate()
        {
            jump();
        }

        void jump()
        {
          if (Input.GetButtonDown("Jump"))
          {
            rb.AddForce(new Vector3(0f, jforce,0f));
          }
        }

                void flip()
        {

        }

                void move()
        {

        }
}
