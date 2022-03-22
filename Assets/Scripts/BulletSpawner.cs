using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{ 
    public float speed = 1;
    public GameObject bullet;
    public float Force;
    private AudioSource sound;
    
    void Start(){
        sound = GetComponent<AudioSource>();
    }
   public void ShootBullet(){
       var bulletInstance = Instantiate(bullet);
       bulletInstance.transform.position = transform.position;
       bulletInstance.GetComponent<Rigidbody>().velocity = transform.forward * speed;
       bulletInstance.GetComponent<Rigidbody>().AddForce(new Vector3(Force, 0f, 0f));
   }
}
