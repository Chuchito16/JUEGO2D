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

    // Use this for initialization
    void Start()
    {
        // La inicialización del temporizador se realiza desde los GameController
        // para permitir reanudar tiempos globales entre escenas.
    }

    public void TimerStart()
    {
        if (!isRunning)
        {
            print("START");
            isRunning = true;
            startTime = Time.time;
        }
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
        timerTime = 0;
        isRunning = false;
        timerMinutes.text = timerSeconds.text = timerSeconds100.text = "00";
    }

    public void InitializeFromGlobal(float timeValue)
    {
        stopTime = timeValue;
        timerTime = timeValue;
        UpdateDisplay(timerTime);
    }

    public float CurrentTime => timerTime;

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            timerTime = stopTime + (Time.time - startTime);
            UpdateDisplay(timerTime);
        }
    }

    private void UpdateDisplay(float displayTime)
    {
        int minutesInt = (int)displayTime / 60;
        int secondsInt = (int)displayTime % 60;
        int seconds100Int = (int)(Mathf.Floor((displayTime - (secondsInt + minutesInt * 60)) * 100));

        timerMinutes.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
        timerSeconds.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
        timerSeconds100.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();
    }
}
