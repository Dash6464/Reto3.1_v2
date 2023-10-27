using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fantasmas : MonoBehaviour
{
   public static int lifes;
    public GameObject Live_3;
    public GameObject Live_2;
    public GameObject Live_1;
    // Start is called before the first frame update
    void Start()
    {
        lifes = 4;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(lifes);
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            lifes -= 1;
            //Scene scene = SceneManager.GetActiveScene();
            //SceneManager.LoadScene(scene.buildIndex);
            Debug.Log("muere");
            if (lifes == 3)
            {
                Live_3.SetActive(false);
            }
            else if (lifes == 2)
            {
                Live_2.SetActive(false);
            }
            else if (lifes == 1)
            {
                Live_1.SetActive(false);
            }
            else if (lifes == 0)
            {

                SceneManager.LoadScene(6);
            }
        }
        
    }

}
