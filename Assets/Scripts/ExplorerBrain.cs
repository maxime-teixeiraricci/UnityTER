using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ExplorerBrain : Brain, Movable, Alive, Picker
{
    [Header("Unit Stats")]
    [SerializeField]
    private int _currentHealth;
    [SerializeField]
    private int _maxHealth;
    [SerializeField]
    private float _speed;
    private NavMeshAgent _navMeshAgent;
    [SerializeField]
    private Inventory _inventory;
    public GameObject _bullet;
    [SerializeField]
    private ItemBehavior _itemBehave;
    [SerializeField]
    public Dictionary<string, Action> actions = new Dictionary<string, Action>();

    public float heading;

    [Header("Debug")]
    public bool isMoving;
    public bool isShooting;
    public bool blocked;
    public string nameAction;


    void Start()
    {
      
    }

    void Update()
    {
        /*
        if (isMoving)
        {
            move();
        }
        if (isShooting || Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
            isShooting = !isShooting;
        }
        */
        blocked = isBlocked();
        if (blocked)
        {
            heading = Random.Range(0, 360);
        }

        if (actions.ContainsKey(nameAction))
        {
            actions[nameAction].Do();
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

    // ACTIONS //
    public void move()
    {
        _navMeshAgent.isStopped = false;
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

    public void idle()
    {
        _navMeshAgent.isStopped = true;
    }

    public void take()
    {
        if (_itemBehave != null)
        {
            print(_itemBehave.getName());
            this.take(_itemBehave);
        }
        
    }

    /////////////

    public void take(ItemBehavior i)
    {
        if (!_inventory.isFull())
        {
            if (_inventory.add(i))
            {
                i.getPicked();

                _itemBehave = null;
            }
        }
    }

}
