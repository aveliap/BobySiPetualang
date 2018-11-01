using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour {

    public GameObject panelQuest;
	// Use this for initialization
	void Start () {
        panelQuest.SetActive(false);
	}

    //private void OnTriggerEnter2D(Collider2D player)
   // {
    //    if (player.gameObject.tag=="box")    
     //   {
    //        panelQuest.SetActive(true);
     ///       Debug.Log("touched");
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "box")
        {
            panelQuest.SetActive(true);
            Debug.Log("touched");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "box")
        {
            Debug.Log("exit");
            panelQuest.SetActive(false);
            Destroy(collision.gameObject);
        }
    }


}
