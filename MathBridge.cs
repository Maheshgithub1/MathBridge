using UnityEngine;
using UnityEngine.UI;

public class MathBridge : MonoBehaviour
{
    public Text questionText;
    public InputField answerInput;
    public Button submitButton;
    public GameObject plank;

    private int correctAnswer;

    void Start()
    {
        GenerateQuestion();
        submitButton.onClick.AddListener(CheckAnswer);
    }

    void GenerateQuestion()
    {
        int a = Random.Range(1, 10);
        int b = Random.Range(1, 10);
        correctAnswer = a + b;
        questionText.text = $"What is {a} + {b}?";
    }

    void CheckAnswer()
    {
        if (int.Parse(answerInput.text) == correctAnswer)
        {
            Instantiate(plank, transform.position + new Vector3(1, 0, 0), Quaternion.identity);
            GenerateQuestion();
            answerInput.text = "";
        }
        else
        {
            questionText.text = "Try again!";
        }
    }
}
