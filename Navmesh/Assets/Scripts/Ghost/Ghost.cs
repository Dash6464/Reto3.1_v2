using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ghost : MonoBehaviour
{
    public Transform target2;
    Vector3 dest2;
    UnityEngine.AI.NavMeshAgent agente2;
    // Start is called before the first frame update
    void Start()
    {
        agente2 = GetComponent<UnityEngine.AI.NavMeshAgent>();
        dest2 = agente2.destination;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(dest2, target2.position) > 1.0f)
        {
            dest2 = target2.position;
            agente2.destination = dest2;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
            Destroy(other.gameObject);
        }
    }
}
