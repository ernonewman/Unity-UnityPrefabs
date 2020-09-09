using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float ShootingForce = 10f;
    public Vector3 ShootingDirection;
    public GameObject ExplosionPrefab;

    public float LifeTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(ShootingDirection * ShootingForce);
    }

    private void Update()
    {
        LifeTime -= Time.deltaTime;

        if (LifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "TriggerExplosion")
        {
            GameObject explosionObject = Instantiate(ExplosionPrefab);

            explosionObject.transform.position = transform.position;
        }
    }
}
