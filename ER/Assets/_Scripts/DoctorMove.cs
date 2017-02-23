/*
 * Kevin Luu
 * Feb 23, 2017
 * Purpose: To facilitate the movement of the doctor prefab and make it move to the correct rooms.
 */

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
    int wpOld;

    bool moving;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        index = Random.Range(0, roomPoints.Length);
        
        moving = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (moving == true)
        {
            Move();
        }
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Target")
        {
            StartCoroutine(WaitaBit());
            index = Random.Range(0, roomPoints.Length);
            oldPoint = index;
            if (index == oldPoint)
                index = Random.Range(0, roomPoints.Length);
            currentPoint = roomPoints[index];
        }
    }

    void Patrol()
    {
        Debug.Log("Room: " + (index + 1));
        transform.position = Vector2.MoveTowards(transform.position, roomPoints[index].transform.position, forwardMultiplier * Time.deltaTime);
    }

    IEnumerator WaitaBit()
    {
        moving = false;
        yield return new WaitForSeconds(2f);
        transform.position = new Vector2(98.6f, -48.3f);
        moving = true;

    }

    public void Move()
    {
        if (index == 0 || index == 1)
        {
            wpOld = 0;
            transform.position = Vector2.MoveTowards(transform.position, checkpoints[0].transform.position, forwardMultiplier * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, roomPoints[index].transform.position, forwardMultiplier * Time.deltaTime);

        }
        if (index == 2 || index == 3)
        {
            wpOld = 1;
            transform.position = Vector2.MoveTowards(transform.position, checkpoints[1].transform.position, forwardMultiplier * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, roomPoints[index].transform.position, forwardMultiplier * Time.deltaTime);

        }
        if (index == 4 || index == 5)
        {
            wpOld = 2;
            transform.position = Vector2.MoveTowards(transform.position, checkpoints[2].transform.position, forwardMultiplier * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, roomPoints[index].transform.position, forwardMultiplier * Time.deltaTime);

        }
        if (index == 6 || index == 7)
        {
            wpOld = 3;
            transform.position = Vector2.MoveTowards(transform.position, checkpoints[3].transform.position, forwardMultiplier * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, roomPoints[index].transform.position, forwardMultiplier * Time.deltaTime);

        }
        Patrol();

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Patient")
        {
            moving = false;
        }
        else
        {
            moving = true;
        }

    }

    public void Heal()
    {

    }
}
