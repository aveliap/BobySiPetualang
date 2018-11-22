using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScore : MonoBehaviour {

    public int scor;
    public GameObject scoreUI;
    public Text score;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update () {
	
	}

     void OnTriggerEnter2D(Collider2D trig)  
    {
        CountScore();
    }

    void CountScore()
    {
        if (DBManager.LoggedIn)
        {
            score.text = "Skor "+ DBManager.username+": " + scor ;
        }
        
    }

}
