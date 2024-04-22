using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
     public float health;
    public float damage;
    public float speed;
    public bool elite;
    // Start is called before the first frame update
    void Start()
    {
        elite = false;
        speed = Random.value * 2;
        damage = Random.value * 2;
        health = 10;

        Debug.Log("You encounter an enemy! It has " + health + " health, " + speed + " speed, and " + damage + " damage");
    }
}
