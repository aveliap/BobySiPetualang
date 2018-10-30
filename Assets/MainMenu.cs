using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour {

    public Text playerDisplay;

	public void QuitGame () {
		Debug.Log("QUIT");
		Application.Quit();
	}

    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Selamat Datang, " + DBManager.username;
        }
    }
    public void Play()
    {
        SceneManager.LoadScene("DialogScene");
    }
}
