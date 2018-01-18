using UnityEngine;
using System.Collections;

public class VehicleController : MonoBehaviour
{

    public int speed;
    public Transform[] patrolPoints;
    public bool move = true;
    public Vector3 startPos;

    void Start()
    {
        transform.position = patrolPoints[0].position;
        startPos = transform.position;
    }

    void Update()
    {
        if (move)
        {
            transform.position = Vector3.MoveTowards(transform.position, patrolPoints[1].position, speed * Time.deltaTime);
        }
    }

    IEnumerator Wait()
    {
        move = false;
        yield return new WaitForSeconds(3);
        move = true;
    }

    public void Button_Click()
    {
        transform.position = startPos;
        StartCoroutine(Wait());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            move = false;
        }
        if (other.gameObject.tag == "Stop")
        {
            StartCoroutine(Wait());
        }
    }
}

