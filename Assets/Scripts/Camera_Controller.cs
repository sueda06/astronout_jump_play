using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public Transform hero;
    public Transform bgCenter;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        if (hero.position.y >= transform.position.y)
        {
            transform.position = new Vector3(
                transform.position.x,
                hero.position.y,
                 transform.position.z
                );
        }
        if (transform.position.y >= bgCenter.position.y+ 12.8f)
        {
            bgCenter.position = new Vector2(
                bgCenter.position.x,
                transform.position.y + 12.8f
                );
        }
    }
}
