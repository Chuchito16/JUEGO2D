using UnityEngine;

public class GameControllerScene2 : MonoBehaviour
{
    public Timer tiempoEscena;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (tiempoEscena != null && GameManager.instance != null)
        {
            tiempoEscena.InitializeFromGlobal(GameManager.instance.GlobalTime1);
            tiempoEscena.TimerStart();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
