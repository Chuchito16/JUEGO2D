using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScene1 : MonoBehaviour
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

    public void IrAEscena(string sceneName)
    {
        if (tiempoEscena != null && GameManager.instance != null)
        {
            tiempoEscena.TimerStop();
            GameManager.instance.GlobalTime1 = tiempoEscena.CurrentTime;
        }
        SceneManager.LoadScene(sceneName);
    }
}
