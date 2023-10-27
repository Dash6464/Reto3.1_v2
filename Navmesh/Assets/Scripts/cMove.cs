using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cMove : MonoBehaviour
{
    public Vector3[] puntoRutas;

    public float speed;

    public int indice = 0;

    public int direcion;
    // Start is called before the first frame update
    void Start()
    {

    }

    IEnumerator moverPersonaje()
    {
        while (true)
        {
            Vector3 siguientePunto = puntoRutas[indice];

            while (transform.position != siguientePunto)
            {
                transform.position = Vector3.MoveTowards(transform.position, siguientePunto, speed * Time.deltaTime);
                yield return null;
            }
            indice += direcion;

            if (indice >= puntoRutas.Length || indice < 0)
            {
                direcion *= -1;
                indice += direcion * 2;
            }
        }
    }
}
