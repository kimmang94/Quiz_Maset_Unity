using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timerValue;
    [SerializeField] private float timeToCompleteQuestion = 30f; // ��� Ǯ��� �ϴ� �ð�
    [SerializeField] private float timeToShowCorrectAnswer = 10f; // ���� ���� �ð� 

    public bool isAnsweringQuestion = false;
    // Update is called once per frame
    private void Update()
    {
        UpdateTimer();
    }

    /// <summary>
    /// Ÿ�̸� �ð����� ���
    /// </summary>
    private void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        if (isActiveAndEnabled)
        {
            if (timerValue <= 0)
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if (timerValue <= 0)
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
            }
        }

        if (timerValue <= 0 )
        {
            timerValue = timeToCompleteQuestion;
        }
        Debug.Log($"timer : {timerValue}");
    }
}
