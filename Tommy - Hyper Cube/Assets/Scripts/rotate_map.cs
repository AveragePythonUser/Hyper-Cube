using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class rotate_map : MonoBehaviour
{

    public GameObject map;
    public GameObject point;
    public float degrees;
    public float rotate_time;
    public Vector3 vector_axis;

    private bool rotating = false;

    void Update()
    {
        if (rotating == true)
        {
            map.transform.RotateAround(point.transform.position, vector_axis, (degrees / rotate_time) * Time.deltaTime);
        }

        Debug.Log()
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(flip());
        }
    }

    IEnumerator flip()
    {
        rotating = true;
        yield return new WaitForSeconds(rotate_time);
        if (vector_axis == new Vector3(1, 0, 0))
        {
            map.transform.rotation *= Quaternion.Euler(0, 1, 1);
        }

        rotating = false;

    }
}
