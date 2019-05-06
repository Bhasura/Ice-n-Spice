using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{
    public float damage = 40f;
    public float range = 50f;
    public Camera fpsCamera;
    public float impactForce = 50f;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    private Vector3 rayOrigin;
    public Transform gunEnd;
    private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);
    private LineRenderer laserLine;

    void Start()
    {
        laserLine = GetComponent<LineRenderer>();
    }

    public void onShootButton()
    {
        ShootGun();

        StartCoroutine(ShotEffect());
        rayOrigin = fpsCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
        laserLine.SetPosition(0, gunEnd.position);
    }

    /*public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootGun();
            
            StartCoroutine(ShotEffect());
            rayOrigin = fpsCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
            laserLine.SetPosition(0, gunEnd.position);
        }
    }*/

    public void ShootGun()
    {
        muzzleFlash.Play(); // particle system

        RaycastHit hit;
        if (Physics.Raycast(rayOrigin, fpsCamera.transform.forward, out hit, range)) // if the raycast has hit anything
        {
            laserLine.SetPosition(1, hit.point);
            ShootableBox enemy = hit.transform.GetComponent<ShootableBox>();
            if (enemy != null)
            {
                enemy.Damage(damage);
                // have to add animation each time hit
                GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 1f);
            }
            if (hit.rigidbody != null) // might not need this if flying - my enemies right now don't have rigidbodies
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
        else
        {
            laserLine.SetPosition(1, rayOrigin + (fpsCamera.transform.forward * range));
        }
    }

    private IEnumerator ShotEffect()
    {
        // Turn on our line renderer
        laserLine.enabled = true;

        //Wait for .07 seconds
        yield return shotDuration;

        // Deactivate our line renderer after waiting
        laserLine.enabled = false;
    }
}
