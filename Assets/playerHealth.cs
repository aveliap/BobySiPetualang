using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.y < -5 )
        {
            Die();
        }
        
	}

    void Die ()
    {
        new WaitForSeconds(1);
        SceneManager.LoadScene("Gameover");
        
    }
}
