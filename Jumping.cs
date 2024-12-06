using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayorMask;
    public float jumpHeight = 10f;
    private float modJumpHeight;
    public float jump = 2f;
    private float jumpAc;
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    private float temp;
    public Animator animator;


    void Start()
    {
        
        rb = transform.GetComponent<Rigidbody2D>();
        bc = transform.GetComponent<BoxCollider2D>();
        temp = jumpHeight;
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        isGrounded();
        if (jumpAc < jump && Input.GetButtonDown("Jump"))
        {

            
            rb.velocity = Vector2.up * temp;
            temp -= jumpHeight * (1/jump);
            jumpAc++;
            Debug.Log(temp);

        }
    }
        
    
    
    private void isGrounded()
    {
        RaycastHit2D raycastHit2d= Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 0f, Vector2.down, .1f, platformLayorMask);
        //return raycastHit2d.collider != null;
        if (raycastHit2d.collider != null)
        {
            jumpAc = 0;
            temp = jumpHeight;
        }
    }
}
