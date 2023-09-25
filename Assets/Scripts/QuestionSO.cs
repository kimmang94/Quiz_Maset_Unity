using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Questin", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [SerializeField]
    [TextArea(2, 6)]
    private string questuion = "Enter new question text here";

    [SerializeField]
    private string[] answers = new string[4];

    [SerializeField]
    private int correctAnswerIndex;
    public string GetQuestion()
    {
        return questuion;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }
    
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
    
} 
