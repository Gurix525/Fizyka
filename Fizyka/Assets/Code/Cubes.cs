using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IEDestroyAfterSeconds());
    }

    IEnumerator IEDestroyAfterSeconds()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
