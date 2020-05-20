using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            GameObject[] players = GameObject.FindGameObjectsWithTag("player");
            Vector3 p1 = players[0].transform.position;
            Vector3 p2 = players[1].transform.position;
            players[1].transform.position = p1;
            players[0].transform.position = p2;
            GameObject.Destroy(this.gameObject);


        }
    }
}
