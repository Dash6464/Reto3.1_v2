using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones_inicio : MonoBehaviour
{
    //Music sound;
    int scene;


    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 2)
        {
            GameObject.FindGameObjectWithTag("MainMusic").GetComponent<Music>();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Levels()
    {
        SceneManager.LoadScene("Reto 1");
    }
    public void About()
    {
        SceneManager.LoadScene("About");
    }
    public void Back()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }


    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif

    }

}
