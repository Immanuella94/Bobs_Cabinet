using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Important _Direction -> 0 = X AXIS  1 = Z AXIS
    public CharacterController controller;
    public float run = 20f;
    public float walk = 10f;
    float speed = 6f;
    int _direction = 0; // like _Direction

    bool runActive = false;

    public Animator animator;

    bool facingRight = true;


    void Start()
    {
        speed = walk;
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (Input.GetKey("e"))
        {
            runActive = !runActive;
        }

        if (runActive == true)
        {
            speed = run;
        }
        else if (runActive == false)
        {
            speed = walk;
        }



        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }

        if (_direction == 0)
        {
            animator.SetBool("X-Axis", true); //left and right
            animator.SetBool("WalkingDown", false);
            animator.SetBool("WalkingUp", false);
            animator.SetFloat("Speed", Mathf.Abs(horizontal));
        }

        if (_direction == 1) //nach vorne
        {
            animator.SetBool("X-Axis", false); //up and down
            animator.SetBool("WalkingDown", true);
            animator.SetBool("WalkingUp", false);
            animator.SetFloat("Speed", Mathf.Abs(vertical));
        }

        if (_direction == 2) //nach hinten
        {
            animator.SetBool("WalkingUp", true);
            animator.SetBool("X-Axis", false); //up and down
            animator.SetBool("WalkingDown", false);
            animator.SetFloat("Speed", Mathf.Abs(vertical));
        }

        if (_direction == 3) //nach hinten
        {
            animator.SetBool("X-Axis", false);
            animator.SetBool("WalkingDown", false);
            animator.SetBool("WalkingUp", false);
        }

        if (horizontal > 0 && !facingRight) //flip to the right
        {
            Flip();
        }

        if (horizontal < 0 && facingRight) //flip to the left
        {
            Flip();
        }


        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            _direction = 2;
        }

        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            _direction = 1;

        }

        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            _direction = 0;

        }

        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            _direction = 0;
        }


    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }


}