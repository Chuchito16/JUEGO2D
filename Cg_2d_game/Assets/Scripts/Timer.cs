using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    //#region sonidos
    //[SerializeField]
    //private AudioClip stop;
    //[SerializeField]
    //private AudioSource respuestaAudio;
    ////Reloj objReloj;
    //#endregion

    public TextMeshProUGUI timerMinutes;
    public TextMeshProUGUI timerSeconds;
    public TextMeshProUGUI timerSeconds100;

    private float startTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;

    public float CurrentTime => timerTime;

    // Use this for initialization
    void Start()
    {
        TimerStart();
    }

    public void InitializeFromGlobal(float elapsed)
    {
        stopTime = timerTime = elapsed;
        UpdateTimerDisplay(timerTime);
    }

    public void TimerStart()
    {
        if (!isRunning)
        {
            print("START");
            isRunning = true;
            startTime = Time.time;
        }

        //crear un else donde reciba el valor del tiempo cambiado en el loaderscenes para empezar un timer a partir del tiempo que ya llevamos
    }

    public void TimerStop()
    {
        if (isRunning)
        {
            print("STOP");
            isRunning = false;
            stopTime = timerTime;
            Debug.Log(stopTime.ToString());
            ///
            //if (stopTime >= 30)
            //{
            //    respuestaAudio.clip = stop;
            //    respuestaAudio.Play();
            //}
            //aadir un return para que pueda pasarle el dato del tiempo total hasta que se pause el tiempo a gamemanager
        }
    }

    public void TimerReset()
    {
        print("RESET");
        stopTime = 0;
        isRunning = false;
        timerMinutes.text = timerSeconds.text = timerSeconds100.text = "00";
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            timerTime = stopTime + (Time.time - startTime);
            UpdateTimerDisplay(timerTime);
        }
        else
        {
            timerTime = stopTime;
        }
    }

    private void UpdateTimerDisplay(float time)
    {
        int minutesInt = (int)time / 60;
        int secondsInt = (int)time % 60;
        int seconds100Int = (int)(Mathf.Floor((time - (secondsInt + minutesInt * 60)) * 100));
        timerMinutes.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
        timerSeconds.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
        timerSeconds100.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();
    }
}
