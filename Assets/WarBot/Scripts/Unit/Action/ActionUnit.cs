using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionUnit : MonoBehaviour
{
    public delegate void Act();

    // Liste des déclarations des actions. (ACTION_...)

    public Dictionary<string, Act> _actions = new Dictionary<string, Act>();

    void Start()
    {
        _actions["ACTION_MOVE"] = delegate () { GetComponent<MovableCharacter>().Move(); };
        _actions["ACTION_RANDOM_MOVE"] = delegate () 
        {
            GetComponent<Stats>()._heading = Random.Range(0, 360);
            GetComponent<MovableCharacter>().Move();
        };
        _actions["ACTION_HEAL"] = delegate () { GetComponent<Inventory>().use(); };
        _actions["ACTION_IDLE"] = delegate () { };

        _actions["ACTION_PICK"] = delegate () {
            GameObject target = GetComponent<Stats>()._target;
            if (target != null) {
                Objet obj = target.GetComponent<ItemHeldler>()._heldObjet;
                Inventory unitInventory = GetComponent<Inventory>();
                unitInventory.add(obj);
                Destroy(target);
            }
        };
        _actions["ACTION_GIVE"] = delegate () {
            GameObject target = GetComponent<Stats>()._target;
            Objet objectToGive = GetComponent<Stats>()._objectToUse;
            if (target != null && objectToGive != null)
            {
                Objet item = target.GetComponent<ItemHeldler>()._heldObjet;
                if (GetComponent<Inventory>()._objets.ContainsKey(item) && GetComponent<Inventory>()._objets[item] != 0 && target.GetComponent<Inventory>())
                {
                    target.GetComponent<Inventory>().add(item);
                    print("Base ressource : " + target.GetComponent<Inventory>()._objets[item]);
                    GetComponent<Inventory>().pop(item);
                }
            }
        };
        _actions["ACTION_FIRE"] = delegate () {
            GameObject target = GetComponent<Stats>()._target;
            if (target != null)
            {
                if (GetComponent<Stats>()._reloadTime <= 0)
                {
                    GameObject bullet = Instantiate(_bullet, this.transform.position, Quaternion.identity);
                    bullet.GetComponent<BulletScript>()._owner = gameObject;
                    bullet.GetComponent<BulletScript>()._vect = transform.forward;
                }
            }
        };
        _actions["ACTION_RELOAD"] = delegate () { };
        _actions["ACTION_CREATE"] = delegate () {
            GameObject target = GetComponent<Stats>()._target;
            Objet objectToUse = GetComponent<Stats>()._objectToUse;
            if (target != null && objectToUse != null)
            {
                if (GetComponent<Inventory>()._objets[objectToUse] >= 10)
                {
                    Ray ray;
                    float dx, dz;
                    Vector3 pos;
                    do
                    {
                        dx = Mathf.Cos(Random.Range(0, 2 * Mathf.PI));
                        dz = Mathf.Sin(Random.Range(0, 2 * Mathf.PI));
                        pos = new Vector3(4 * dx + transform.position.x, transform.position.y + 0.5f, 5 * dz + transform.position.z);
                        ray = new Ray(pos, Vector3.down * 2);

                    } while (!Physics.Raycast(ray.origin, ray.direction));
                    GameObject unit = Instantiate(target, pos, Quaternion.identity);
                    unit.GetComponent<Team>()._color = GetComponent<Team>()._color;
                    GetComponent<Inventory>()._objets[objectToUse] -= 10;
                }
            }
        };
    }
}
