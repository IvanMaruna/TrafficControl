using UnityEngine;
using System.Collections;

public class EndPosition : MonoBehaviour
{
    public GameManager gm;
    public static int PointsToEnd;

    void Start()
    {
        PointsToEnd = gm.GetComponent<GameManager>().NumOfCars.Length;
    }

    void Update()
    {
        if(PointsToEnd == 0)
        {
            gm.CompleteLevel();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Car")
        {
            PointsToEnd--;
        }
    }
}
