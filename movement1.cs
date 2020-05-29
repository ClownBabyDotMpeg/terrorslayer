using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement1 : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("OVRPlayerController").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.transform.position.z > gameObject.transform.position.z)
        {
            transform.Translate(Vector3.forward  * _speed * Time.deltaTime);
        }
        else{transform.Translate(Vector3.back * _speed * Time.deltaTime);}

        if (_player.transform.position.x > gameObject.transform.position.x)
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        else{transform.Translate(Vector3.left * _speed * Time.deltaTime);}

        //fliocker 
        if (_player.transform.position.y > gameObject.transform.position.y)
        {
            transform.Translate(Vector3.up * (_speed * 10) * Time.deltaTime);
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        else transform.Translate(Vector3.down * (_speed * 10) * Time.deltaTime); transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
}
