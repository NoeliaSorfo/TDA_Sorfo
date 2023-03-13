using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum Comportamiento 
{
  Uno,Dos
}

public class Enemy_3 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy3;
    public float speed = 1f;
    public float dist;
    public Comportamiento _comportamiento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (_comportamiento)
        {
          case Comportamiento.Uno:
            LookQuaternionsEnemy_1();
            break;

          case Comportamiento.Dos:
            LookQuaternionsEnemy_2();
            MoveLerpEnemy2();
            break;
        }
       
        dist = Vector3.Distance(Player.transform.position, Enemy3.transform.position);
    }

     private void LookQuaternionsEnemy_1()
      {
       Quaternion rot = Quaternion.LookRotation(Player.transform.position - Enemy3.transform.position);
       Enemy3.transform.rotation = rot;
    }

     private void LookQuaternionsEnemy_2()
      {
       Quaternion rot = Quaternion.LookRotation(Player.transform.position - Enemy3.transform.position);
       Enemy3.transform.rotation = rot;
    }
     private void MoveLerpEnemy2()
      {
        if (dist <= 2)
        {
            speed = 0;
        }
        else
        {
            speed = 1f;
        }

        Enemy3.transform.position = 
        Vector3.Lerp(Enemy3.transform.position, Player.transform.position, speed * Time.deltaTime);
      }

}