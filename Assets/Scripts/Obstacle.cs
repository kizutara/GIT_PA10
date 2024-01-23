﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float Speed = 3;
    public GameManager GM;
    private void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (transform.position.x <= -8)
        {
            GM.UpdateScore(1);
            Destroy(gameObject);
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * -Speed);
        }
    }
}
