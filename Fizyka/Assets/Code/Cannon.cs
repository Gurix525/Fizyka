using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Code;

public class Cannon : MonoBehaviour, IButtonReceiver
{
    [SerializeField] private GameObject _explosionCenter;
    [SerializeField] private float _explosionForce = 100;

    public void Execute()
    {
        foreach (Transform child in _explosionCenter.transform)
        {
            child.gameObject.GetComponent<Rigidbody>().AddExplosionForce(_explosionForce, _explosionCenter.transform.position, 10);
        }
    }
}
