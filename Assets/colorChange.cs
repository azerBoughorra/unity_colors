using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    public Material red;
    public Material green;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject[] grounds = GameObject.FindGameObjectsWithTag("ground");
        foreach (var ground in grounds)
        {
            if (ground.layer == 9)
            {
                ground.layer = 8;
                ground.GetComponent<Renderer>().material = green;


            }
            else if (ground.layer == 8)
            {
                ground.layer = 9;
                ground.GetComponent<Renderer>().material = red;

            }

        }
        GameObject.Destroy(this.gameObject);


    }
}
