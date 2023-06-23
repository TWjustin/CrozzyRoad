using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarMove : MonoBehaviour
{
    public float minSpeed = 1f;
    public float maxSpeed = 2f;
    
    private bool movingLeft = false;

    private void Start()
    {
        // 根据生成的prefab的x坐标来确定移动方向
        if (transform.position.x > 0)
        {
            movingLeft = true; // 向左移动
        }
        else
        {
            movingLeft = false; // 向右移动
        }
    }
    void Update()
    {
        
        if (movingLeft)
        {
            float speed = Random.Range(minSpeed, maxSpeed);
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else
        {
            float speed = Random.Range(minSpeed, maxSpeed);
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("destroy"))
        {
            Destroy(gameObject);
        }
    }
}
