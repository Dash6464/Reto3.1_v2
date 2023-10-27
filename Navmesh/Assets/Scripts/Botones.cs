using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    //Music sound;
    int scene;


    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 1)
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
        SceneManager.LoadScene(1);
    }

    public void cargarJuego()
    {
        SceneManager.LoadScene("Reto 1");
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
