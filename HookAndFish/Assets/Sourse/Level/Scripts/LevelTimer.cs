using UnityEngine;
using TMPro;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;

    private int levelMinutes = 1; 
    private int levelSeconds = 0; 
    private float currentTime = 0f;

    void Start()
    {
        StartLevelTimer();
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        UpdateTimerUI();

        if (currentTime <= 0f)
            LevelEnd();
    }

    void StartLevelTimer()
    {
        currentTime = levelMinutes * 60 + levelSeconds;
        UpdateTimerUI();
    }

    void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void LevelEnd()
    {
        Debug.Log("Level Time's up!");
    }
}