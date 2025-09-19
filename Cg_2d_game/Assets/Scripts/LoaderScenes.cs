using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScenes : MonoBehaviour
{
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
        //añadir aca un metodo para devolver el valor del tiempo que llevamos y lo devolvemos al timer
        SceneManager.LoadScene(nameScene);
    }
}
