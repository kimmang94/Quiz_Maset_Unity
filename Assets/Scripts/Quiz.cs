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
       // DisplayQuestion();
        GetNetxQuestion();
    }

    /// <summary>
    /// 정답을 맞출시 문제 출력 Text 에  정답text를 보여주는 기능
    /// </summary>
    private void DisplayQuestion()
    {
        questionText.text = question.GetQuestion();
        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }

    /// <summary>
    /// 버튼을 다시 누를수있게 만들고 다음 문제를 제시하는 기능
    /// </summary>
    private void GetNetxQuestion()
    {
        SetButtonState(true);
        SetDefaultButtonSprites();
        DisplayQuestion();
    }
    
    /// <summary>
    /// 정답 선택시 버튼기능 비활성화
    /// </summary>
    /// <param name="state"></param>
    private void SetButtonState(bool state)
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            Button button = answerButtons[i].GetComponent<Button>();
            button.interactable = state;
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

        SetButtonState(false);
    }

    /// <summary>
    /// 기본 버튼으로 변경
    /// </summary>
    private void SetDefaultButtonSprites()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            Image buttonImage = answerButtons[i].GetComponent<Image>();
            buttonImage.sprite = defaultSprite;
        }
    }
}
