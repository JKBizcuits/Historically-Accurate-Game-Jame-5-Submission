using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Animator animator;
    public float movementSpeed;
    public Rigidbody2D rb;
    float movementX;

    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(movementX));

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            sr.flipX = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            sr.flipX = false;
        }
        /*if (Input.GetKeyDown(KeyCode.X))
        {
            movementSpeed = 0;
            movementX = 0;
            animator.SetFloat("Speed", Mathf.Abs(movementX));
            animator.SetBool("hack", true);

        }
        else if(Input.GetKeyUp(KeyCode.X))
        {
            animator.SetBool("hack", false);
        }
        */
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(movementX * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }
}
