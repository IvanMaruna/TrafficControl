using UnityEngine;
using System.Collections;

public class Square : MonoBehaviour {
    public int num;
    private bool clicked=false;

    void OnMouseDown()
    {
        GameManager.gm.ClickSquare(this,num,clicked);
        clicked = true;
    }
}
