using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Q1 : MonoBehaviour {

    List<string> a = new List<string>() {
     "Portugis",
     "Seikerei",
     "Membungkukkan badan ke arah negara jepang",
     "Perjuangan bersifat kedaerahan",
     "Hiroshima dan Nagasaki",
     "Badan Penyelidik Usaha Persiapan Kemerdekaan Indonesia",
     "Ir. Soekarno"
    };
    public int skor;
    Text textJawab;
	// Use this for initialization
	void Start () {
        textJawab = GameObject.Find("1").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Question.randQuestion>-1)
        {
            textJawab.text = a[Question.randQuestion];
            //GetComponent<TextMesh>().text = a[Question.randQuestion];
        }   
	}

     public void OnMouseDown()
    {
        Question.selectedAnswer = gameObject.name;
        Question.choiceSelected = "y";
    }
}
