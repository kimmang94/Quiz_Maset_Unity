using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;


public class Quiz : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI questionText = null;
    [SerializeField]
    private QuestionSO question = null;
    [SerializeField]
    private GameObject[] answerButtons;

    private int correctAnswerIndex = 0;
    [SerializeField]
    private Sprite defaultSprite= null;
    [SerializeField]
    private Sprite correctAnswerSprite = null;
    
    private void Start()
    {
        questionText.text = question.GetQuestion();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }

    /// <summary>
    /// 정답 index를 선택해서 정답이면 정답효과, 오답시 오답효과
    /// </summary>
    /// <param name="index"></param>
    public void OnAnswerSelected(int index)
    {
        Image buttonImage;
        if (index == question.GetCorrectAnswerIndex())
        {
            questionText.text = "Correct!";
            buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
        else
        {
            correctAnswerIndex = question.GetCorrectAnswerIndex();
            string correctAnswer = question.GetAnswer(correctAnswerIndex);
            questionText.text = "Sorry, the correct answer was; \n" + correctAnswer;
            buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
    }

}
