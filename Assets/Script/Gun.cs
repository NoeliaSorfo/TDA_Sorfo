using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int CantidadBalas = 10;
    public float range = 100f;
    public Camera fpsCam;
    public GameObject impactEnemigo;
    public GameObject impactWall;
    public ParticleSystem flashEffect;

    public string[] objectArray;

    //public ParticleSystem CasquillosEffect;

    public AudioSource _audSource;
    public AudioClip _clip_Disparo;
    public AudioClip _clip_Hit;
    public AudioClip _clip_Hit_wall;

    void Start()
    {
        objectArray = new string[3] {"Enemigo", "Obstaculos", "Floor"};
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Disparar();
        }
    }

    void Disparar()
        {
        CantidadBalas --;
        RaycastHit hit;
        AudioPlay(_clip_Disparo);

        //flashEffect.Play();
        //CasquillosEffect.Play();

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            for(int i=0 ; i < objectArray.Length ; i++)
                {
                if (hit.transform.name == "Enemigo" && objectArray[i] == "Enemigo")
                    {
                    Debug.Log(hit.transform.name);
                    hit.transform.gameObject.GetComponent<Enemigo>().VidaEnemigo -= 10f;
                    AudioPlay(_clip_Hit);
                    GameObject impactEnemy = Instantiate(impactEnemigo, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(impactEnemy,3f);
                    }
                }

            for(int i=2 ; i > 0 ; i--)
                {
                if (hit.transform.name == "Obstaculos" && objectArray[i] == "Obstaculos")
                    {
                    Debug.Log(hit.transform.name);
                    AudioPlay(_clip_Hit);
                    GameObject impactPared = Instantiate(impactWall, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(impactPared,3f);
                    }
                }
            
            for(int i=0 ; i < objectArray.Length ; i++)
                {
                if (hit.transform.name == "Floor" && objectArray[i] == "Floor")
                    {
                    Debug.Log(hit.transform.name);
                    AudioPlay(_clip_Hit);
                    GameObject impactPared = Instantiate(impactWall, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(impactPared,3f);
                    }
                }
            }
        }

    void AudioPlay(AudioClip _clip_test)
    {
        _audSource.clip = _clip_test;
        _audSource.Play();
    }
}
