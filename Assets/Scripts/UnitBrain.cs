using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitBrain : MonoBehaviour, Movable, Alive, Picker
{
    [Header("Unit Stats")]
    [SerializeField]
    private int _currentHealth;
    [SerializeField]
    private int _maxHealth;
    [SerializeField]
    private float _speed;
    private NavMeshAgent _navMeshAgent;
    private Inventory _inventory;
    public GameObject _bullet;

    public float heading;

    [Header("Debug")]
    public bool isMoving;
    public bool isShooting;
    public bool blocked;


    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _speed = _navMeshAgent.speed;
    }

    void Update()
    {
        if (isMoving)
        {
            move();
        }
        if (isShooting || Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
            isShooting = !isShooting;
        }
        blocked = isBlocked();
        if (blocked)
        {
            heading = Random.Range(0, 360);
        }
    }

    public int getHealth()
    {
        return _currentHealth;
    }

    public int getMaxHealth()
    {
        return _maxHealth;
    }

    public double getSpeed()
    {
        return _speed;
    }

    public bool isBlocked()
    {
        
        return !_navMeshAgent.hasPath;
    }

    public void move()
    {
        float h = Mathf.Deg2Rad * heading;
        Vector3 dest = transform.position + new Vector3(Mathf.Sin(h), 0, Mathf.Cos(h)).normalized;
        Debug.DrawLine(transform.position, dest, Color.green);
        _navMeshAgent.destination = dest;
    }

    public void shoot()
    {
        GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.identity);
        float h = Mathf.Deg2Rad * heading;
        bullet.GetComponent<BulletScript>().vect = new Vector3(Mathf.Sin(h), 0, Mathf.Cos(h)).normalized;

    }

    public void take(Item i)
    {
        if (!_inventory.isFull())
        {
            if (_inventory.add(i))
            {
                i.getPicked();
            }
        }
    }
}
