using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timerValue;
    [SerializeField] private float timeToCompleteQuestion = 30f; // 퀴즈를 풀어야 하는 시간
    [SerializeField] private float timeToShowCorrectAnswer = 10f; // 정답 검토 시간 
    // Update is called once per frame
    private void Update()
    {
        UpdateTimer();
    }

    /// <summary>
    /// 타이머 시간관리 기능
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
