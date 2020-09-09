using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObject = Instantiate(BulletPrefab);

            Bullet bullet = bulletObject.GetComponent<Bullet>();
            Vector3 shootingDirection =
                new Vector3(
                    Random.Range(-0.15f, 0.15f),
                    Random.Range(-0.1f, 0.1f),
                    1);

            bullet.ShootingDirection = shootingDirection.normalized;
        }
    }
}
