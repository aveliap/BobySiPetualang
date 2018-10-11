using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Register : MonoBehaviour
{
    public InputField username;
    public InputField password;
    public InputField confpassword;

    public Button RegisterBtn;


    public void daftar()
    {
        SceneManager.LoadScene("register");
    }

    public void CallRegist()
    {
        StartCoroutine(CreateUser());
    }
    IEnumerator CreateUser()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username.text);
        form.AddField("password", password.text);

        WWW www = new WWW("http://localhost/edugame/createuser.php", form);
        yield return www;
        if(www.text == "0")
        {
            Debug.Log("Akun anda telah terdaftar");
            UnityEngine.SceneManagement.SceneManager.LoadScene("login");
        }
        else
        {
            Debug.Log("Akun gagal dibuat. Error #" + www.text);
        }
    }

    public void VerifyInput()
    {
        RegisterBtn.interactable = (username.text.Length >= 5 && password.text.Length >= 6 );
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }

            if (password.GetComponent<InputField>().isFocused)
            {
                confpassword.GetComponent<InputField>().Select();
            }
            if (confpassword.GetComponent<InputField>().isFocused)
            {
                username.GetComponent<InputField>().Select();
            }
        }
        

        


    }
}