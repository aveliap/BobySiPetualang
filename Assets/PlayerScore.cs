using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerScore : MonoBehaviour {

    private int playerScore;
    public GameObject scoreUI;
    //public Text score;
    // Use this for initialization
    void Start()
    {
        playerScore = 0;
        scoreUI.gameObject.GetComponent<Text>().text = ("Skor " + DBManager.username + ": " + playerScore);
    }

    // Update is called once per frame
    void Update () {
        //enemnyscor();

    }

    public void AddPoints(int amount)
    {
        playerScore = playerScore + amount;
        scoreUI.gameObject.GetComponent<Text>().text = "score:" + playerScore;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name =="End")
        {
            new WaitForSeconds(1);
            SceneManager.LoadScene("Gameover");
        }
    }


    //void enemnyscor()
    //{

    //    RaycastHit2D rayDown = Physics2D.Raycast(transform.position, Vector2.down);

    //    if (rayDown.distance < 2.0f && rayDown.collider.tag == "enemy")
    //    {
    //        Debug.Log(scor += 10);
    //        //Debug.Log("bisa");
    //        scor += 10;
    //    }
    //}

    //public void OnTriggerEnter2D(Collider2D trig)  
    //{
    //    if (trig.tag=="enemy")
    //    {
    //        Debug.Log("aa");
    //        scor += 10;

    //    }
    //}

    //void CountScore()
    //{
    //    if (DBManager.LoggedIn)
    //    {
    //        scoreUI.gameObject.GetComponent<Text>().text = "Skor " + DBManager.username + ": " + scor;
    //    }

    //}

}
