using UnityEngine;
using UnityEngine.Networking;

public class Player1CarWeapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float force;
    public int damage;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }


    void Fire()
    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * force;

        Destroy(bullet, 2.0f);
    }
}