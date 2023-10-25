using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_player : MonoBehaviour
{
    public float speed;
    public string direction;

    Vector3 move;

    float hspeed;
    float vspeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hspeed = Input.GetAxis("Horizontal");
        float vspeed = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(0f, vspeed, hspeed);
        move.Normalize();
        transform.position = transform.position + move * speed * Time.deltaTime;


    }

    void FixedUpdate()
    {

    }
}
