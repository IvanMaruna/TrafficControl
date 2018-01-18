using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
    public static GameManager gm;

    public GameObject StopSign;
    public GameObject[] NumOfCars;

    void Start () {

        if (gm == null)
        {
            gm = gameObject.GetComponent<GameManager>();
        }
        
    }

    public void ClickSquare(Square other,int num, bool clicked)
    {
        if (num == -1 && clicked == false)
        {
            Instantiate(StopSign, other.gameObject.transform.position, Quaternion.Euler(0, 90, 0));
        }
        else if(clicked == false)
            Instantiate(StopSign, other.gameObject.transform.position, Quaternion.identity);
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Completed!");
    }

}
