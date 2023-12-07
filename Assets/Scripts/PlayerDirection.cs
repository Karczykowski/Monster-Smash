using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirection : MonoBehaviour
{
    Vector2 mousePosition; //Starting at left bottom corner
    Vector2 worldPosition; //Starting at the middle of the screen
    void Update()
    {
        mousePosition = Input.mousePosition;
        worldPosition = (Vector2)Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 dir = worldPosition - (Vector2)transform.position;
        float rotZ = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion targetRot = Quaternion.Euler(0, 0, rotZ);

        transform.localRotation = targetRot;
    }
}
