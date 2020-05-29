using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int _health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Player Methods

    public void DMG(int recieved)
    {

        _health -= recieved;

        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
