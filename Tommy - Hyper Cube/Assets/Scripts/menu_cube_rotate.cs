using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_cube_rotate : MonoBehaviour
{

    //
    // Rotates the cubes you see in the menu
    // probably could have merged this with the
    // object button script but do I really feel like doing that (no)
    //
    
    public static float speed;

    public float min_speed = 0.3f;
    public float max_speed = 0.4f;

    private float x;
    private float y;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(min_speed, max_speed);

        x = (Random.Range(-1f, 1f) * speed);
        y = (Random.Range(-1f, 1f) * speed);
        z = (Random.Range(-1f, 1f) * speed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x, y, z);
    }

}
