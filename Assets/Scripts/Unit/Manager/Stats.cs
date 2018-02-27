using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Stats : MonoBehaviour
{
    public float _heading;
    public Team _myTeam;
    public bool _isBlocked;
    public int _health;
    public int _maxHealth;
    public float _reloadTime;
    public ParticleSystem _deathAnimation;
    //public Dictionary<string, Object> stats;

    void Start()
    {
        _heading = Random.Range(0, 360);
    }
    void Update()
    {
        _reloadTime -= Time.deltaTime;
        //_heading = -transform.eulerAngles.y + 90;
        _heading = (_heading + 360) % 360;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, _heading +90 , transform.eulerAngles.z);
        _isBlocked = GetComponent<MovableCharacter>()._isblocked;
        if (_isBlocked)
        {
            _heading = Random.Range(0, 360);
        }

        if (_health <= 0)
        {
            _deathAnimation = Instantiate(_deathAnimation);
            _deathAnimation.transform.position = transform.position;
            _deathAnimation.Play();
            Destroy(gameObject);
        }
    }

    
}
