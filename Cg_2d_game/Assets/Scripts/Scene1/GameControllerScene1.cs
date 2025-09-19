using UnityEngine;

public class GameControllerScene1 : MonoBehaviour
{
    public Timer tiempoEscena;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (tiempoEscena == null)
        {
            tiempoEscena = GetComponent<Timer>();
        }

        if (tiempoEscena != null)
        {
            float resumeTime = 0f;
            if (GameManager.instance != null)
            {
                resumeTime = GameManager.instance.GlobalTime1;
            }
            else
            {
                Debug.LogWarning("GameControllerScene1: GameManager instance not found when initializing timer.");
            }

            tiempoEscena.InitializeFromGlobal(resumeTime);
            tiempoEscena.TimerStart();
        }
        else
        {
            Debug.LogWarning("GameControllerScene1: Timer reference is missing.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
