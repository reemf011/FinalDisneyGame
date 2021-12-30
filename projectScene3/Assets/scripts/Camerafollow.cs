using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset = 1f;
    public Transform Target;
    public float Cameraspeed;
    public float minX, maxX;
    public float minY, maxY;
    void start()
    {

    }
    void Update()
    {
        Vector3 newPos = new Vector3(Target.position.x, Target.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }
    void fixedupdate()
    {
        if (Target != null)
        {
            Vector2 newCamPosition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * Cameraspeed);
            float clampx = Mathf.Clamp(newCamPosition.x, minX, maxX);
            float clampy = Mathf.Clamp(newCamPosition.y, minY, maxY);
            transform.position = new Vector3(clampx, clampy, -10f);
        }
    }
}
