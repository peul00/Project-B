using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixDrag : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    public GameObject location;
    public void OnMouseUp()
    {
        transform.position = location.transform.position;
    }
}
