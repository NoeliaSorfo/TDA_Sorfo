using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float VidaEnemigo = 100;

    public GameObject efectoExplosion;

    public AudioSource _audSource;
    public AudioClip _clip_Explosion;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (VidaEnemigo <= 0)
        {
            //AudioPlay(_clip_Explosion);
            GameObject explosionEnemigo = Instantiate(efectoExplosion, transform.position, transform.rotation);
            Destroy(explosionEnemigo,2.1f);
            Destroy(this.gameObject);
        }
 
 
    /*void AudioPlay(AudioClip _clip_test)
        {
        _audSource.clip = _clip_test;
        _audSource.Play();
        } */  
    }
}
