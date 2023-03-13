using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    public GameObject Player;
    public GameObject Pos;
    public Vector3 localScale = new Vector3(1f,1f,1f);
    int tamaño = 1;
    int _timer = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "portal-door")
        {
            if (_timer == 1)
            {
                if (tamaño == 1)
                {
                    Debug.Log("pequeño");
                    Player.transform.localScale = localScale * 0.5f;
                    _timer = 500;
                    tamaño = 2;  
                }
                else
                {
                    Debug.Log("grande");
                    Player.transform.position = Pos.transform.position;
                    Player.transform.localScale = localScale * 1.0f;
                    _timer = 500;
                    tamaño = 1;
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_timer > 1)
        {
            _timer -= 1;
        }
        
    }
}
