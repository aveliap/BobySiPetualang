using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questionn : MonoBehaviour {

    public struct Question
    {
        public string questionText;
        public string[] answers;
        public int correctAnswerIndex;
        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            this.questionText = questionText;
            this.answers = answers;
            this.correctAnswerIndex = correctAnswerIndex;
        }
    }

    private Question currentQuestion; /*= new Question("what is your favo color?", new string[] { "blue", "red", "yellow", "white" }, 0);*/
    public Button[] answerButton;
    public Text questionText ;
    public GameObject panelQuest;
    public PlayerScore score;
    public GameObject scoreUI;


    private Question[] questions = new Question[7];
    private int currentQuestionIndex;
    private int[] questionNumbersChoosen = new int[7];
    private int questionfinished;
    // Use this for initialization
	void Start () {
        questions[0] = new Question("Negara yang pernah menjajah nusantara, yaitu", new string[] { "Portugis", "Amerika", "Belanda", "Jepang" }, 1);
        questions[1] = new Question("Salah satu kekejaman dari penjajah jepang adalah kerja paksa, atau dalam bahasa jepang disebut dengan", new string[] { "Seikerei", "Heiho", "Dokuritsu", "Romusha" }, 3);
        questions[2] = new Question("Ketika jepang menjajah, terdapat ritual yaitu “Seikerei”. Apa itu ritual seikerei?", new string[] { "Membungkukkan badan ke arah negara jepang", "Membungkukkan badan ke arah matahari terbit", "Membungkukkan badan ke arah matahari terbenam", "Membungkukkan badan ke arah rasi bintang timur" }, 1);
        questions[3] = new Question("Perjuangan rakyat Indonesia mengusir penjajah sering  mengalami kegagalan, dikarenakan faktor-faktor berikut", new string[] { "Perjuangan bersifat kedaerahan", "Kurangnya rasa persatuan dan kesatuan", "Lemahnya persenjataan", "Semua benar" }, 3);
        questions[4] = new Question("Jepang menyerah setelah dijatuhi bom atom oleh amerika dan sekutu, kota yang dijatuhi bom atom yaitu", new string[] { "Hiroshima dan Nagasaki", "Tokyo dan Osaka", "Osaka dan Hiroshima", "Tokyo dan Nagasaki" }, 0);
        questions[5] = new Question("Kepanjangan dari BPUPKI adalah", new string[] { "Badan Penyelidik Usaha Persiapan Kemerdekaan Indonesia", "Badan Persiapan Usaha Penyelidikan Kemerdekaan Indonesia", "Badan Penggerak Usaha Persiapan Kemerdekaan Indonesia", "Badan Pengatur Usaha Persiapan Kemerdekaan Indonesia" }, 0);
        questions[6] = new Question("Berikut merupakan salah satu tokoh panitia 9, kecuali", new string[] { "Ir. Soekarno", "Mr. Mohammad Yamin", "H. Agus Salim", "Adam Malik" }, 3);

        chooseQuestion();
        //currentQuestion = questions[currentQuestionIndex];
        assignQuestion(questionNumbersChoosen[0]);
    }   
	
	// Update is called once per frame
	void Update () {
        //scoreUI.gameObject.GetComponent<Text>().text = ("Skor " + DBManager.username + ": " + playerScore);
        
    }

    void assignQuestion(int questionNum)   
    {
        currentQuestion = questions[questionNum];
        questionText.text = currentQuestion.questionText;
        for (int i = 0; i < answerButton.Length; i++)
        {
            answerButton[i].GetComponentInChildren<Text>().text = currentQuestion.answers[i];
        }
    }

   public void checkAnswer(int buttonNum)
    {
        if(buttonNum == currentQuestion.correctAnswerIndex)
        {
            print("correct");
            //Destroy(gameObject);
            //panelQuest.SetActive(false);
            score.AddPoints(10);
        }
        else
        {
            print("incorrect");
            //panelQuest.SetActive(false);
        }

        if (questionfinished < questionNumbersChoosen.Length - 1)
        {
            movetoNextQuestion();
            panelQuest.SetActive(false);
            questionfinished++;
            
        }
    }

    void chooseQuestion()
    {
        for (int i = 0; i < questionNumbersChoosen.Length; i++)
        {
            int questionNum = Random.Range(0, questions.Length);
            if (numberNotContained(questionNumbersChoosen, questionNum))
            {
                questionNumbersChoosen[i] = questionNum;
            }
            else
            {
                i--;
            }
        }

        currentQuestionIndex = Random.Range(0, questions.Length);
    }

    bool numberNotContained(int[] numbers, int num)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (num == numbers[i])
            {
                return false;
            }
        }
        return true;
    }

    public void movetoNextQuestion()
    {
        assignQuestion(questionNumbersChoosen[questionNumbersChoosen.Length - 1 - questionfinished]);
    }
}
