﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;

    [HideInInspector]
    public float speed;

    public float startHealth = 100f;

    [HideInInspector]
    public float health;

    public int worth = 50;

    public GameObject deathEffect;


    [Header("Unity Stuff")]
    public Image healthBar;

    private bool isDead = false;


    private void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;

        if (health <= 0 && !isDead) Die();
    }


    void Die()
    {
        isDead = true;

        GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        WaveSpawner.EnemiesAlive--;

        PlayerStats.Money += worth;
        Destroy(this.gameObject);
    }

    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }

}
