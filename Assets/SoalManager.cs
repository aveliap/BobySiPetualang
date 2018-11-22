using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoalManager : MonoBehaviour {

    List<string> questions = new List<string>() {
        "Negara yang pernah menjajah nusantara, yaitu",
        "Salah satu kekejaman dari penjajah jepang adalah kerja paksa, atau dalam bahasa jepang disebut dengan",
        "Ketika jepang menjajah, terdapat ritual yaitu “Seikerei”. Apa itu ritual seikerei?",
        "Perjuangan rakyat Indonesia mengusir penjajah sering  mengalami kegagalan, dikarenakan faktor-faktor berikut",
        "Jepang menyerah setelah dijatuhi bom atom oleh amerika dan sekutu, kota yang dijatuhi bom atom yaitu",
        "Kepanjangan dari BPUPKI adalah",
        "Berikut merupakan salah satu tokoh panitia 9, kecuali"
    };

    List<string> a = new List<string>() {
     "Portugis",
     "Seikerei",
     "Membungkukkan badan ke arah negara jepang",
     "Perjuangan bersifat kedaerahan",
     "Hiroshima dan Nagasaki",
     "Badan Penyelidik Usaha Persiapan Kemerdekaan Indonesia",
     "Ir. Soekarno"
    };

    List<string> b = new List<string>() {
     "Amerika",
     "Heiho",
     "Membungkukkan badan ke arah matahari terbit",
     "Kurangnya rasa persatuan dan kesatuan",
     "Tokyo dan Osaka",
     "Badan Persiapan Usaha Penyelidikan Kemerdekaan Indonesia",
     "Mr. Mohammad Yamin"
    };

    List<string> c = new List<string>() {
     "Belanda",
     "Dokuritsu",
     "Membungkukkan badan ke arah matahari terbenam",
     "Lemahnya persenjataan",
     "Osaka dan Hiroshima",
     "Badan Penggerak Usaha Persiapan Kemerdekaan Indonesia",
     "H. Agus Salim"
    };

    List<string> d = new List<string>() {
     "Jepang",
     "Romusha",
     "Membungkukkan badan ke arah rasi bintang timur",
     "Semua benar",
     "Tokyo dan Nagasaki",
     "Badan Pengatur Usaha Persiapan Kemerdekaan Indonesia",
     "Adam Malik"
    };

    List<string> correctAnswer = new List<string> { "2", "4", "2", "4", "1", "1", "4" };

    public static string selectedAnswer;
    public static string choiceSelected = "n";
    private int randQuestion;
    Text textSoal, textA,textB,textC,textD,score;
    public int skor;
    // Use this for initialization
    void Start () {
        textSoal = GameObject.Find("Question").GetComponent<Text>();
        textA = GameObject.Find("1").GetComponent<Text>();
        textB = GameObject.Find("2").GetComponent<Text>();
        textC = GameObject.Find("3").GetComponent<Text>();
        textD = GameObject.Find("4").GetComponent<Text>();
        score = GameObject.Find("skor").GetComponent<Text>();
        randQuestion = Random.Range(0, questions.Count);
    }
	
	// Update is called once per frame
	void Update () {
        score.text = "Skor : " + skor;
        
        textSoal.text = questions[randQuestion];
        
        textA.text = a[randQuestion];
         
            textB.text = b[randQuestion];
           
            textC.text = c[randQuestion];
            
            textD.text = d[randQuestion];
            

        if (choiceSelected == "y")
        {
            choiceSelected = "n";

            if (correctAnswer[randQuestion] == selectedAnswer)
            {
                Debug.Log("benar");
                skor++;
            }
        }
    }

    public void cekjawab(string jawab)
    {
        selectedAnswer = gameObject.name;
        jawab = choiceSelected;
        jawab = "y";
        if (jawab == "y")
        {
            jawab = "n";

            if (correctAnswer[randQuestion] == selectedAnswer)
            {
                Debug.Log("benar");
                skor++;
            }
        }
    }

}
