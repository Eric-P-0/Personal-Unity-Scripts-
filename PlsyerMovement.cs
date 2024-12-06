using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlsyerMovement : MonoBehaviour
{   
    //movement variables
    public float horizontalMove = 10f;
    public float speed = 10f;
    public float health = 4;
    private Vector2 moveVelocity;
    Rigidbody2D rb;
    private GameObject go;
    public Animator animator;
    public bool m_FacingRight;
    void Start()
    {
        go = GameObject.FindWithTag("player"); // Finds gameobject with tag 'player'.
        rb = GetComponent<Rigidbody2D> ();//Adding Rigid body 2D to script
    }

    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
       
        //Clamp for player to not pass fixed "start"
        //Expirement with using vector 2D not just 3 since im using 2d
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -9.53f, 36.267f),
             transform.position.y,
             transform.position.z);
    }
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");//Orign is 0 pressing "A" or left makes value -1 meaninf left movement and pressing "D" or right means +1 which is moving right (like a number line)

        if (move < 0)
        {
            m_FacingRight = false;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            rb.velocity = new Vector2(speed * move, rb.velocity.y);
        }
        else
        {
            m_FacingRight = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            rb.velocity = new Vector2(speed * move, rb.velocity.y);
        }//move(horizontalMove * Time.fixedDeltaTime, false, false);
        
       
             // Vector2 taking two arguments (x,y) since 2D
       
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            health--;

            if (health <=0 )
            {
                Destroy(go.gameObject);
            }
                 
        }
    }
}
   
