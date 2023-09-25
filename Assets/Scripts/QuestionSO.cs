using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Questin", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [SerializeField]
    [TextArea(2, 6)]
    private string questuion = "Enter new question text here";

    public string GetQuestion()
    {
        return questuion;
    }
    
    
    
} 
