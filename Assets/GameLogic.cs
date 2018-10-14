using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;

public class GameLogic : MonoBehaviour {
    public static float time = 60f;
    public static float score = 0f;
    public Text Score;
    public Text StartTime;
    public GameObject ScoreBoard;
    public float totalpoint;
    public Text TotalPointTxt;
    // Use this for initialization
    void Start () {
        ScoreBoard.SetActive(false);
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        Score.text = score.ToString();
        StartTime.text = (Mathf.Ceil(time)).ToString();
        totalpoint = score + time;
        TotalPointTxt.text = (Mathf.Ceil(totalpoint)).ToString() + "  คะแนน";

        if (score == 90)
        {
            Time.timeScale = 0;
            ScoreBoard.SetActive(true);
        }
        if (time <= 0)
        {
            time = 0f;
            Time.timeScale = 0;
            ScoreBoard.SetActive(true);
        }

    }
}
