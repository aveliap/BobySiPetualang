using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q2 : MonoBehaviour {

    List<string> b = new List<string>() {
     "Amerika",
     "Heiho",
     "Membungkukkan badan ke arah matahari terbit",
     "Kurangnya rasa persatuan dan kesatuan",
     "Tokyo dan Osaka",
     "Badan Persiapan Usaha Penyelidikan Kemerdekaan Indonesia",
     "Mr. Mohammad Yamin"
    };

    Text textJawab;
    // Use this for initialization
    void Start()
    {
        textJawab = GameObject.Find("2").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        //for (int i = 0; i < b.Capacity; i++)
        //{
            if (Question.randQuestion > -1)
            {
                textJawab.text = b[Question.randQuestion];
                // GetComponent<TextMesh> ().text = b [Question.randQuestion];
            }
        //}
        
    }


     void OnMouseDown()
    {
        Question.selectedAnswer = gameObject.name;
        Question.choiceSelected = "y";
    }
}
