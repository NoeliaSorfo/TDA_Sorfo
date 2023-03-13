using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy1;
    public float speed = 1f;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      LookQuaternionsEnemy_1();
       
    }

    private void LookQuaternionsEnemy_1()
      {
       Quaternion rot = Quaternion.LookRotation(Player.transform.position - Enemy1.transform.position);
       Enemy1.transform.rotation = rot;
    }

}