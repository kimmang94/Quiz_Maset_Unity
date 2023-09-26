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
    
    private void Start()
    {
        questionText.text = question.GetQuestion();
    }

}
