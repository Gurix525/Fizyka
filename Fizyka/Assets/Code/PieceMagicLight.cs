using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMagicLight : MonoBehaviour
{
    [SerializeField] private List<Light> lights = new List<Light>();

    private Rigidbody _rigidbody;
    private bool _isTriggered = false;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (_rigidbody.velocity.y > 0.5f && !_isTriggered)
        {
            StartCoroutine(IELightning());
            _isTriggered = true;
        }
    }

    IEnumerator IELightning()
    {
        while (lights[0].intensity < 100)
        {
            foreach (Light light in lights) light.intensity += Time.deltaTime * 100;
            yield return null;
        }
        while (lights[0].intensity > 0)
        {
            foreach (Light light in lights) light.intensity -= Time.deltaTime * 100;
            yield return null;
        }
    }
}
