using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionLightCreate : Action
{
    public Objet ressource;
    public GameObject _unitToCreate;

    public override void Do()
    {
        
        if (GetComponent<Inventory>()._objets[ressource] >= 10)
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
            GameObject unit = Instantiate(_unitToCreate, pos, Quaternion.identity);
            unit.GetComponent<Team>()._color = GetComponent<Team>()._color;
            GetComponent<Inventory>()._objets[ressource] -= 10;



        }
    }

}