using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;
    public GameObject player;
    Transform target;
    NavMeshAgent agent;


    //public ParticleSystem explosionEffect;
    //public CameraShake cameraShake;
    
    void Start()
    {
        //GameObject t = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
       // Vector3 tPosition = target.position;

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
                Exploding();
            }
        }
    }

    private void Exploding()
    {
        //Instantiate(explosionEffect, transform.position, transform.rotation);
        //explosionEffect.Play();
       // StartCoroutine(cameraShake.Shake(0.15f, 0.4f));

        Destroy(this.gameObject);
        PlayerHp.health = PlayerHp.health - 10;
        print(PlayerHp.health);
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
