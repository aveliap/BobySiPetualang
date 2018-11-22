using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textcontrol : MonoBehaviour
{

    List<string> quuestions = new List<string>() {
        "Negara yang pernah menjajah nusantara, yaitu",
        "Salah satu kekejaman dari penjajah jepang adalah kerja paksa, atau dalam bahasa jepang disebut dengan",
        "Ketika jepang menjajah, terdapat ritual yaitu “Seikerei”. Apa itu ritual seikerei?",
        "Perjuangan rakyat Indonesia mengusir penjajah sering  mengalami kegagalan, dikarenakan faktor-faktor berikut",
        "Jepang menyerah setelah dijatuhi bom atom oleh amerika dan sekutu, kota yang dijatuhi bom atom yaitu",
        "Kepanjangan dari BPUPKI adalah",
        "Berikut merupakan salah satu tokoh panitia 9, kecuali"
    };

    List<string> coorrectAnswer = new List<string> { "2", "4", "2", "4", "1", "1", "4" };

    public static string selectedAnswer;
    public static string chooiceSelected = "n";
    public static int ruandQuestion = -1;

    // Use this for initialization
    void Start()
    {
        //GetComponent<TextMesh> ().text = questions[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (ruandQuestion == -1)
        {
            ruandQuestion = Random.Range(0, 7);
        }
        if (ruandQuestion > -1)
        {
            GetComponent<TextMesh> ().text = quuestions[ruandQuestion];
        }

        if (chooiceSelected == "y")
        {
            chooiceSelected = "n";

            if (coorrectAnswer[ruandQuestion] == selectedAnswer)
            {
                Debug.Log("benar");
            }
        }
        //Debug.Log(questions[randQuestion]);
    }
}
