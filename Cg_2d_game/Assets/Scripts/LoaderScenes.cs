using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScenes : MonoBehaviour
{
    [SerializeField]
    private Timer activeTimer;

    private void Awake()
    {
        EnsureTimerReference();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void lectorEscena(string nameScene)
    {
        EnsureTimerReference();
        if (activeTimer != null)
        {
            activeTimer.TimerStop();

            float currentTotal = activeTimer.CurrentTime;
            GameManager manager = GameManager.instance;
            if (manager != null)
            {
                float previousTotal = manager.GlobalTime1;
                float delta = currentTotal - previousTotal;
                if (delta < 0f)
                {
                    delta = currentTotal;
                }
                manager.SumaTimeGlobal(delta);
            }
            else
            {
                Debug.LogWarning("LoaderScenes: GameManager instance not found when recording time.");
            }

            activeTimer.TimerReset();
            activeTimer = null;
        }
        else
        {
            Debug.LogWarning("LoaderScenes: No Timer found to record time before loading scene.");
        }

        SceneManager.LoadScene(nameScene);
    }

    private void EnsureTimerReference()
    {
        if (activeTimer == null)
        {
            activeTimer = FindObjectOfType<Timer>();
        }
    }
}
