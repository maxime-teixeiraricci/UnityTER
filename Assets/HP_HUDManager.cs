using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_HUDManager : MonoBehaviour
{
    public Transform _target;
    public int _value;
    public int _maxValue;
    public Text _HPText;
    public Image _HPImage;
    public Vector3 _delta;
	
	// Update is called once per frame
	void Update ()
    {
        _value = _target.gameObject.GetComponent<Stats>()._health;
        _value = Mathf.Max(0, Mathf.Min(_target.GetComponent<Stats>()._maxHealth, _value));
        _HPImage.fillAmount = (1.0f * _value) / _target.GetComponent<Stats>()._maxHealth;
        _HPText.text = "" + _value;
        transform.position = Camera.main.WorldToScreenPoint(_target.position + _delta);
	}
}
