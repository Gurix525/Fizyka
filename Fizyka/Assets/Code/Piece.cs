using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    [SerializeField] private GameObject _particlesPrefab;

    private bool _destroyInitialized = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Piece>() != null && _destroyInitialized == false)
        {
            _destroyInitialized = true;
            StartCoroutine(IEDestroyAfterSeconds());
        }
    }

    private IEnumerator IEDestroyAfterSeconds()
    {
        yield return new WaitForSeconds(1f);
        GameObject particles = Instantiate(_particlesPrefab, transform);
        particles.transform.SetParent(transform.parent);
        Destroy(gameObject);
    }
}
