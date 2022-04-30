using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Code;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _buttonReceiver;

    private void OnCollisionEnter(Collision collision)
    {
        _buttonReceiver.GetComponent<Cannon>().Execute();
    }
}