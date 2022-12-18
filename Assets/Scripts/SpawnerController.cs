using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject prefab;
    public float speed;
    public float minX;
    public float maxX;
    public float interval;
   
    void Start()
    {
        InvokeRepeating("spawn",interval,interval);
    }

   
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
    private void spawn()
    {
        GameObject newPlat = Instantiate(prefab);
        newPlat.transform.position = new Vector2(
            Random.Range(minX,maxX),
            transform.position.y + (Random.Range(0.5f, 1f))
            );
    }
}
