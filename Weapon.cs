using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private int _dmg;
    public int _damage { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        _damage = _dmg;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* //Collisions
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.tag == "Enemy")
        {

        }
    }*/

    // Weapon methods
    private void Shoot()
    {

    }
}
