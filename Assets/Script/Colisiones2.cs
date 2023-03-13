using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject WallPos1;
    public GameObject WallPos2;
    int _timer = 1;
    int _trigger = 0;
    Vector3 rotationVector = new Vector3(0, 30, 0);

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "SmartWall")
        {
            _trigger = 1;

            if (_timer >= 2000)
            {
                if (other.transform.position == WallPos1.transform.position)
                {
                    Debug.Log("teleport");
                    other.transform.position = WallPos2.transform.position;
                    other.transform.rotation *= Quaternion.Euler(0, 30, 0);
                    _timer = 1;
                    _trigger = 0;
                }
                else
                {
                    Debug.Log("teleport");
                    other.transform.position = WallPos1.transform.position;
                    other.transform.rotation *= Quaternion.Euler(0, 30, 0);
                    _timer = 1;
                    _trigger = 0;
                }
            }
        }
        else
        {
            _trigger = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_trigger == 1)
        {
            if(_timer < 2000)
            {
                _timer += 1;
            }
            
        }
        else
        {
            _timer = 1;
        }
    }
}
