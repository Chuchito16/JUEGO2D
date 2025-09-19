using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private float GlobalTime=0;

    public float GlobalTime1 { get => GlobalTime; set => GlobalTime = value; }

    private void Awake()
    {
        if(instance==null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SumaTimeGlobal(float timescene)
    {

    }
}
