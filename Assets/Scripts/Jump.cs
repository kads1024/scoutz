using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float FallMultiplier;
    public float ShortJumpMultiplier;
    public float JumpVelocity;

    private bool jumpRequest;
    private bool isGrounded;

    private Rigidbody rb;
    public PointerHandler input;

    Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (input.pointerdown)
        {
            jumpRequest = true;
            input.pointerdown = false;
            animator.SetTrigger("Jump");
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        if (jumpRequest && isGrounded)
        {
            rb.AddForce(Vector2.up * JumpVelocity, ForceMode.Impulse);

            jumpRequest = false;
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics2D.gravity.y * (FallMultiplier - 1f) * Time.deltaTime;
            

        }
        else if (rb.velocity.y > 0 && !input.pointerhold)
        {
            rb.velocity += Vector3.up * Physics2D.gravity.y * (ShortJumpMultiplier - 1f) * Time.deltaTime;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isGrounded = true;
            animator.SetTrigger("Land");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isGrounded = false;
        }
    }
}
