using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy2;
    public float speed = 0.001f;
    public float dist;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       LookQuaternionsEnemy_2();
       MoveLerpEnemy_2();

        dist = Vector3.Distance(Player.transform.position, Enemy2.transform.position);

        if (dist <= 2)
        {
            speed = 0;
        }
        else
        {
            speed = 1f;
        }
    }

    private void LookQuaternionsEnemy_2()
      {
       Quaternion rot = Quaternion.LookRotation(Player.transform.position - Enemy2.transform.position);
       Enemy2.transform.rotation = rot;
    }

    private void MoveLerpEnemy_2()
    {
        Enemy2.transform.position = 
        Vector3.Lerp(Enemy2.transform.position, Player.transform.position, speed * Time.deltaTime);
    }

}
