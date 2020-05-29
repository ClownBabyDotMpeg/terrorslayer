using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField]
    private int _enemyType;
    [SerializeField]
    private int _dmg;
    [SerializeField]
    private float _timeTillDeath;
    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private int _lives = 1;
    [SerializeField]
    private int _scoreMod;
    [SerializeField]
    private float _fireRate;
    [SerializeField]
    private float _left, _right, _ceiling, _floor;
    /*[SerializeField]
    private GameObject _laserPrefab;


    private bool _doesFire;
    private float _canFire = -1;
   

    private Animator _death_anim;
    private LvlManager _lvlMan;
    private AudioSource _death_audio;
    */
    [SerializeField]
    private Player _player;

    //~~~~~~~~~~~~~~
    void Start()
    {
        /*//~~~~~~~~~~~grab and null
        _left = PlayerPrefs.GetFloat("_left");
        _right = PlayerPrefs.GetFloat("_right");
        _ceiling = PlayerPrefs.GetFloat("_ceiling");
        _floor = PlayerPrefs.GetFloat("_floor");
        _death_anim = GetComponent<Animator>(); if (_death_anim == null) { Debug.LogError("Death anim null"); }
        _death_audio = GameObject.Find("Explosion").GetComponent<AudioSource>(); if (_death_audio == null){ Debug.LogError("death audio null"); }
        _lvlMan = GameObject.Find("SpawnContainer").GetComponent<LvlManager>(); if (_lvlMan == null) { Debug.LogError("lvl man null"); }
        _player = GameObject.Find("PlayerOne").GetComponent<Player>(); if (_player == null) { Debug.LogError("spawn null"); }
        //~~~~~~~~~~~~~~~~~
        _lvlMan.AddEnemy(_enemyType);
        */
    }
    void Update()
    {
        //if (_doesFire == true) { Shoot(); }
        Move(_enemyType);

    }
    //~~~~~~~~~~~~~~~

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile")
        {
            Destroy(other.gameObject);
            _lives--;
            if (_lives <= 0)
            {

                /*_lvlMan.ScoreUp(_scoreMod);
                _lvlMan.AddDead();

                _death_anim.SetTrigger("isDead");
                _death_audio.Play();
                */
                Destroy(GetComponent<Collider>());
                _speed = 0;
                Destroy(gameObject, _timeTillDeath);

            }
        }
        if (other.tag == "Player")
        {

            if (_player != null)
            {
                //_player.Dmg(_dmg);
            }
            Destroy(gameObject, _timeTillDeath);
            //_death_anim.SetTrigger("isDead");
            Destroy(GetComponent<Collider>());
            //_death_audio.Play();

        }
    }

    private void Move(int type)
    {
        float randomX = Random.Range(_left, _right);
        float randomY = Random.Range(_floor, _ceiling);
        switch (type)
        {
            case 0://moving up
                if (transform.position.y >= _ceiling)
                {
                    transform.position = (new Vector3(randomX, _floor, 0));
                }
                else transform.Translate(Vector3.up * _speed * Time.deltaTime);
                break;

            case 1://moving down

                if (transform.position.y <= _floor)
                {
                    transform.position = (new Vector3(randomX, _ceiling, 0));
                }
                else transform.Translate(Vector3.down * _speed * Time.deltaTime);
                break;



            case 2://moving left

                if (transform.position.x <= _left)
                {
                    transform.position = (new Vector3(_right, randomY, 0));
                }
                else transform.Translate(Vector3.left * _speed * Time.deltaTime);
                break;

            case 3://moving right
                if (transform.position.x >= _right)
                {
                    transform.position = (new Vector3(_left, randomY, 0));
                }
                else transform.Translate(Vector3.right * _speed * Time.deltaTime);
                break;


            case 4://following down                
                if (_player.transform.position.x > gameObject.transform.position.x)
                {
                    transform.Translate(Vector3.right * _speed * Time.deltaTime);
                }
                else
                {
                    transform.Translate(Vector3.left * _speed * Time.deltaTime);
                }

                if (transform.position.y <= _floor)
                {
                    transform.position = (new Vector3(randomX, _ceiling, 0));
                }
                else transform.Translate(Vector3.down * _speed * Time.deltaTime);
                break;
            case 5://follow up
                if (_player.transform.position.x > gameObject.transform.position.x)
                {
                    transform.Translate(Vector3.right * _speed * Time.deltaTime);
                }
                else
                {
                    transform.Translate(Vector3.left * _speed * Time.deltaTime);
                }

                if (transform.position.y >= _ceiling)
                {
                    transform.position = (new Vector3(randomX, _floor, 0));
                }
                else transform.Translate(Vector3.up * _speed * Time.deltaTime);
                break;

            case 6://following left
                if (_player.transform.position.y > gameObject.transform.position.y)
                {
                    transform.Translate(Vector3.up * _speed * Time.deltaTime);
                }
                else
                {
                    transform.Translate(Vector3.down * _speed * Time.deltaTime);
                }
                if (transform.position.x <= _left)
                {
                    transform.position = (new Vector3(_right, randomY, 0));
                }
                else transform.Translate(Vector3.left * _speed * Time.deltaTime);
                break;

            case 7://follow right
                if (_player.transform.position.y > gameObject.transform.position.y)
                {
                    transform.Translate(Vector3.up * _speed * Time.deltaTime);
                }
                else
                {
                    transform.Translate(Vector3.down * _speed * Time.deltaTime);
                }
                if (transform.position.x >= _right)
                {
                    transform.position = (new Vector3(_left, randomY, 0));
                }
                else transform.Translate(Vector3.right * _speed * Time.deltaTime);
                break;

            case 8://follow 
                if (_player.transform.position.y > gameObject.transform.position.y)
                {
                    transform.Translate(Vector3.up * _speed * Time.deltaTime);
                }
                else
                {
                    transform.Translate(Vector3.down * _speed * Time.deltaTime);
                }

                if (_player.transform.position.x > gameObject.transform.position.x)
                {
                    transform.Translate(Vector3.right * _speed * Time.deltaTime);
                }
                else
                {
                    transform.Translate(Vector3.left * _speed * Time.deltaTime);
                }
                break;

        }

    }
    /*void Shoot()
    {
        if (Time.time > _canFire)
        {
            _canFire = _fireRate + Time.time;
            Instantiate(_laserPrefab, transform.position + new Vector3(0, -.4f, 0), Quaternion.identity);
            _laserSource.Play();
        }
    }
    */
}
