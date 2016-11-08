#pragma strict

var distance : float = 10;

function OnMouseDrag () {

    if (Input.GetAxis("Mouse ScrollWheel") > 0) // forward
    {
        distance++;
    }
    if (Input.GetAxis("Mouse ScrollWheel") < 0) // back
    {
        distance--;
    }

    var mousePosition : Vector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
    var objPosition : Vector3 = Camera.main.ScreenToWorldPoint(mousePosition);

    transform.position = objPosition;
}


