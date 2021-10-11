using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zadatak_1_11102021 : MonoBehaviour
{
    public Text timerScreen;
    public int mainTime = 0;
    public int min;
    public int sec;

    private void Start()
    {
        StartCoroutine(TimerUpdate());
    }

    IEnumerator TimerUpdate()
    {
        while (mainTime < 3600)
        {
            min = (int) mainTime / 60;
            sec = (int) mainTime % 60;
            if(min < 10 && sec < 10)
            {
                timerScreen.text = "0" + min + ":0" + sec;
            }
            else if (min < 10)
            {
                timerScreen.text = "0" + min + ":" + sec;
            }
            else if (sec < 10)
            {
                timerScreen.text = min + ":0" + sec;
            }
            else
            {
                timerScreen.text = min + ":" + sec;
            }
            yield return new WaitForSeconds(1);
            mainTime++;
        }
    }
}
