using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Vector3 originalPos;

    private void Start()
    {
        originalPos = transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * 1f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * 1f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * 1f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("car"))
        {
            transform.position = originalPos;
        }
    }
}
