using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class Quiz : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI questionText = null;
    [SerializeField]
    private QuestionSO question = null;
    [SerializeField]
    private GameObject[] answerButtons;
    
    private void Start()
    {
        questionText.text = question.GetQuestion();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }

}
