using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScenes : MonoBehaviour
{
    [SerializeField] private GameControllerScene1 gameControllerScene1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameControllerScene1 == null)
        {
            gameControllerScene1 = FindObjectOfType<GameControllerScene1>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void lectorEscena(string nameScene)
    {
        if (gameControllerScene1 != null)
        {
            gameControllerScene1.IrAEscena(nameScene);
        }
        else
        {
            SceneManager.LoadScene(nameScene);
        }
    }
}
