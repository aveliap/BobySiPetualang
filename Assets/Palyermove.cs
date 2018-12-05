using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Palyermove : MonoBehaviour
{

    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 1250;
    private float moveX;
    public bool isGrounded;
    public PlayerScore score;




    //public GameObject scoreUI;
    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerRaycast();
        //scoreUI.gameObject.GetComponent<Text>().text = ("Skor " + DBManager.username + ": " + scor);

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
       
        RaycastHit2D rayDown = Physics2D.Raycast(transform.position, Vector2.down);
        if ( rayDown!=null && rayDown.collider != null && rayDown.distance < 2.0f && rayDown.collider.tag == "enemy")
        {
            //Debug.Log("test");
            GetComponent<Rigidbody2D> ().AddForce(Vector2.up * 1000);
            rayDown.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 200);
            rayDown.collider.gameObject.GetComponent<Rigidbody2D>().gravityScale = 8;
            rayDown.collider.gameObject.GetComponent<Rigidbody2D>().freezeRotation = false;
            rayDown.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            rayDown.collider.gameObject.GetComponent<Enemymove>().enabled = false;

            score.AddPoints(10);
        }
        if (rayDown != null && rayDown.collider != null && rayDown.distance < 1.2f && rayDown.collider.tag == "ground")
        {
            isGrounded = true;
        }
    }
}

