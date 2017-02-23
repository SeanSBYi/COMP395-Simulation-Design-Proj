using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorMove : MonoBehaviour
{
    public float forwardMultiplier = 3f;
    public GameObject[] roomPoints;
    GameObject currentPoint;
    int oldPoint;
    int index;
    Rigidbody2D rb2d;
    public GameObject[] checkpoints;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        index = Random.Range(0, roomPoints.Length);


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (index == 0 || index == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, checkpoints[0].transform.position, forwardMultiplier * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, roomPoints[index].transform.position, forwardMultiplier * Time.deltaTime);

        }
        if (index == 2 || index == 3)
        {
            transform.position = Vector2.MoveTowards(transform.position, checkpoints[1].transform.position, forwardMultiplier * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, roomPoints[index].transform.position, forwardMultiplier * Time.deltaTime);

        }
        if (index == 4 || index == 5)
        {
            transform.position = Vector2.MoveTowards(transform.position, checkpoints[2].transform.position, forwardMultiplier * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, roomPoints[index].transform.position, forwardMultiplier * Time.deltaTime);

        }
        if (index == 6 || index == 7)
        {
            transform.position = Vector2.MoveTowards(transform.position, checkpoints[3].transform.position, forwardMultiplier * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, roomPoints[index].transform.position, forwardMultiplier * Time.deltaTime);

        }
        Patrol();
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Target")
        {
            
            transform.position = new Vector2(98.6f, -48.3f);
            index = Random.Range(0, roomPoints.Length);
            oldPoint = index;
            if (index == oldPoint)
                index = Random.Range(0, roomPoints.Length);
            currentPoint = roomPoints[index];
            Debug.Log(currentPoint);
        }
    }

    void Patrol()
    {
        Debug.Log("Patrolling");
        transform.position = Vector2.MoveTowards(transform.position, roomPoints[index].transform.position, forwardMultiplier * Time.deltaTime);

    }
}
