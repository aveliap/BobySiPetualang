using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemymove : MonoBehaviour {

    public int EnemySpeed;
    public int XMoveDirection;

	
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection, 0) * EnemySpeed;

        if (hit.distance<1.5f)
        {
            Flip();
            if (hit.collider.tag == "Player")
            {
                Destroy(hit.collider.gameObject);
                new WaitForSeconds(1);
                SceneManager.LoadScene("Gameover");
            }
        }
        //if (gameObject.transform.position.y < -50)
        //{
        //    Destroy(gameObject);
        //}

    }
    void Flip()
    {
        if (XMoveDirection > 0)
        {
            XMoveDirection = -1;
        } else
        {
            XMoveDirection = 1;
        }
    }
}
