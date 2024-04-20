using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timerValue;
    [SerializeField] private float timeToCompleteQuestion = 30f; // ��� Ǯ��� �ϴ� �ð�
    [SerializeField] private float timeToShowCorrectAnswer = 10f; // ���� ���� �ð� 
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
        if (timerValue <= 0 )
        {
            timerValue = timeToCompleteQuestion;
        }
        Debug.Log($"timer : {timerValue}");
    }
}
