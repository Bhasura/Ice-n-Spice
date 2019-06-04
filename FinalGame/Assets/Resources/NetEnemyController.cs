using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NetEnemyController : MonoBehaviour
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
        
        //target = player.transform;

        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {

       
        
       


    }

    private void Exploding()
    {
        Destroy(this.gameObject);
        PlayerHp.health = PlayerHp.health - 10;
        print(PlayerHp.health);
    }

    void FaceTargetChild1()
    {
        Vector3 direction = (Room_Controller.child1.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
    void FaceTargetChild2()
    {
        Vector3 direction = (Room_Controller.child2.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
