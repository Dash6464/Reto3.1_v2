using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cambiarColor : MonoBehaviour
{
    new Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        StartCoroutine("cambiar_Color");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StopCoroutine("cambiar_Color");
            print("Se detuvo");
        }
    }

    IEnumerator cambiar_Color()
    {
        yield return new WaitForSeconds(1f);
        renderer.material.color = Color.blue;
        yield return new WaitForSeconds(2f);
        renderer.material.color = Color.red;
        yield return new WaitForSeconds(1.5f);
        renderer.material.color = Color.green;
    }
}
