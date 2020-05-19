using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;

    public float attackSpeed = 8f;
    float nextAttack = 0f;
    bool shooting;

    private void FixedUpdate()
    {
        if (shooting)
        {
            if (Time.time >= nextAttack && this.isActiveAndEnabled)
            {
                Instantiate(bullet, firePoint.position, firePoint.rotation);
                nextAttack = Time.time + 1f / attackSpeed;
            }
        }
        Debug.Log(shooting);
    }
    public void Shooting(bool buttondown)
    {
        buttondown = shooting;
    }

    void Shoot()
    {
        
    }
}
