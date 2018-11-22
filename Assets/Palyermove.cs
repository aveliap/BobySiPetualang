using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palyermove : MonoBehaviour
{

    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 1250;
    private float moveX;
    public bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerRaycast();

    }

    void PlayerMove()
    {
        //controls
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            Jump();
        }
        //animations

        //direction
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        //jumpcode
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("menyentuh" + col.collider.name);
        if (col.gameObject.tag == "ground")
        {
            isGrounded = true;
        }


    }

    void PlayerRaycast()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down);
        if ( hit !=null && hit.collider !=null && hit.distance < 1.2f && hit.collider.gameObject.tag == "enemy")
        {
            GetComponent<Rigidbody2D> ().AddForce(Vector2.up * 1000);
            hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 200);
            hit.collider.gameObject.GetComponent<Rigidbody2D>().gravityScale = 8;
            hit.collider.gameObject.GetComponent<Rigidbody2D>().freezeRotation = false;
            hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            hit.collider.gameObject.GetComponent<Enemymove>().enabled = false;

        }
        if (hit != null && hit.collider != null && hit.distance < 1.2f && hit.collider.tag == "ground")
        {
            isGrounded = true;
        }
    }
}

