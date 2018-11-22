using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Question : MonoBehaviour {

     List<string> questions = new List<string> () {
        "Negara yang pernah menjajah nusantara, yaitu",
        "Salah satu kekejaman dari penjajah jepang adalah kerja paksa, atau dalam bahasa jepang disebut dengan",
        "Ketika jepang menjajah, terdapat ritual yaitu “Seikerei”. Apa itu ritual seikerei?",
        "Perjuangan rakyat Indonesia mengusir penjajah sering  mengalami kegagalan, dikarenakan faktor-faktor berikut",
        "Jepang menyerah setelah dijatuhi bom atom oleh amerika dan sekutu, kota yang dijatuhi bom atom yaitu",
        "Kepanjangan dari BPUPKI adalah",
        "Berikut merupakan salah satu tokoh panitia 9, kecuali"
    };

    List<string> correctAnswer = new List<string> { "2", "4", "2", "4", "1", "1", "4" };

    public static string selectedAnswer;
    public static string choiceSelected = "n";
    public static int randQuestion = -1;
    Text textSoal;
    // Use this for initialization
    void Start()
    {
        textSoal = GameObject.Find("Question").GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        if (randQuestion == -1)
        {
            randQuestion = Random.Range(0, 7);
        }
         if (randQuestion > -1)
        {
            textSoal.text = questions[randQuestion];
            //GetComponent<TextMesh>().text = questions[randQuestion];
        }

        if (choiceSelected == "y")
        {
            //choiceSelected = "n";

            if (correctAnswer[randQuestion] == selectedAnswer)
            {
                Debug.Log("benar");
            }
        }
        //Debug.Log(questions[randQuestion]);
    }

    //public void cekjawaban(){
    //    if (choiceSelected == "y")
    //    {
    //        //choiceSelected = "n";

    //        if (correctAnswer[randQuestion] == selectedAnswer)
    //        {
    //            Debug.Log("benar");
    //        }
    //    }
        //if (correctAnswer[randQuestion].Q1 == true && jawaban == "1")
        //{

        //}
    }

