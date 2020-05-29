using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    [SerializeField]
    private int _damage;

    private int _health = 1;

    private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("OVRPlayerController").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _player.DMG(_damage);
            Destroy(gameObject);
        }
        if (other.tag == "Blade")
        {
            Weapon _weapon = other.GetComponent<Weapon>();
            _health -= _weapon._damage;
            if (_health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
