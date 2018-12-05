using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q3 : MonoBehaviour {

    List<string> c = new List<string>() {
     "Belanda",
     "Dokuritsu",
     "Membungkukkan badan ke arah matahari terbenam",
     "Lemahnya persenjataan",
     "Osaka dan Hiroshima",
     "Badan Penggerak Usaha Persiapan Kemerdekaan Indonesia",
     "H. Agus Salim"
    };
    Text textJawab;
    // Use this for initialization
    void Start()
    {
        textJawab = GameObject.Find("3").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Question.randQuestion > -1)
        {
            textJawab.text = c[Question.randQuestion];
            //GetComponent<TextMesh>().text = c[Question.randQuestion];
        }
    }
     void OnMouseDown()
    {
        Question.selectedAnswer = gameObject.name;
        Question.choiceSelected = "y";
    }
}
