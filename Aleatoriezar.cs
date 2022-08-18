using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatoriezar : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-400, 400), Random.Range(19, 20), Random.Range(-600, -100));

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
