using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 moffset;
    private float mZCoord;
    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        moffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private void Update()
    {
        if (this.transform.position.y<1)
        {
            this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z);
        }
        if (this.transform.position.x<-4)
        {
            this.transform.position = new Vector3(-4, this.transform.position.y, this.transform.position.z);

        }
        if (this.transform.position.x > 4)
        {
            this.transform.position = new Vector3(4, this.transform.position.y, this.transform.position.z);

        }
        if (this.transform.position.y>1)
        {
            this.transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);
        }
    }
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + moffset;
    }
}
