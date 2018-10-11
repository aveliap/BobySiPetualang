using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class login : MonoBehaviour {

    public InputField username;
    public InputField password;

    public Button LoginBtn;


    public void CallLogin()
    {
        StartCoroutine(Loging());
    }

    IEnumerator Loging()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username.text);
        form.AddField("password", password.text);

        WWW www = new WWW("http://localhost/edugame/loginn.php", form);
        yield return www;
        if(www.text[0] == '0')
        {
            DBManager.username = username.text;
            //DBManager.score = int.Parse(www.text.Split('\t')[1]);
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuFull");
        }
        else
        {
            Debug.Log("user login failed error#" + www.text);
        }
    }

    public void VerifyInput()
    {
        LoginBtn.interactable = (username.text.Length >= 5 && password.text.Length >= 6);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
            
        }
    }
}
