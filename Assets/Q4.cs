using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q4 : MonoBehaviour {
    List<string> d = new List<string>() {
     "Jepang",
     "Romusha",
     "Membungkukkan badan ke arah rasi bintang timur",
     "Semua benar",
     "Tokyo dan Nagasaki",
     "Badan Pengatur Usaha Persiapan Kemerdekaan Indonesia",
     "Adam Malik"
    };
    Text textJawab;
    // Use this for initialization
    void Start()
    {
        textJawab = GameObject.Find("4").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Question.randQuestion > -1)
        {
            textJawab.text = d[Question.randQuestion];
            //GetComponent<TextMesh>().text = d[Question.randQuestion];
        }
    }
    public void OnMouseDown()
    {
        Question.selectedAnswer = gameObject.name;
        Question.choiceSelected = "y";
    }

    
}
