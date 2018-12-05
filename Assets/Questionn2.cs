using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questionn2 : MonoBehaviour {

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
    public GameObject popup;

    private Question[] questions = new Question[7];
    private int currentQuestionIndex;
    private int[] questionNumbersChoosen = new int[7];
    private int questionfinished;
    // Use this for initialization
	void Start () {
        questions[0] = new Question("Rumah joglo merupakan rumah adat dari provinsi", new string[] { "Bali", "Sumatera Barat", "Jawa Timur", "Yogyakarta" }, 2);
        questions[1] = new Question("Alat Musik tradisional betawi adalah", new string[] { "Seruling", "Gambang Kromong", "Angklung", "Kendang" }, 1);
        questions[2] = new Question("Linto Baro adalah pakaian adat dari ...", new string[] { "Aceh", "Jawa Timur", "Maluku", "Riau" }, 0);
        questions[3] = new Question("Monumen Nasional, Tugu Proklamasi, dan Monumen Pancasila SAkti terdapat di kota ...", new string[] { "Yogyakarta", "Bandung", "Surabaya", "Jakarta" }, 3);
        questions[4] = new Question("Rendang adalah makanan khas daerah...", new string[] { "Sulawesi Selatan", "Sumatera Barat", "Jawa Tengah", "Aceh" }, 1);
        questions[5] = new Question("Upacara Ngaben berasal dari ...", new string[] { "Bandung", "Bali", "Bogor", "Batam" }, 1);
        questions[6] = new Question("Kerajaan yang ada di daerah jawa timur pada jaman dahulu yaitu...", new string[] { "Samudera pasai", "Singasari", "Sriwijaya", "Tarumanegara" }, 1);

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
            popup.SetActive(true);
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
