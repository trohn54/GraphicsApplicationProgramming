using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transforms : MonoBehaviour
{
    float speed;
    Vector3 temp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speed = Mathf.Sin(.5f);

        temp = transform.localScale;
        temp.x += .03f;
        transform.localScale = temp;
        transform.Rotate(0,1000*speed * Time.deltaTime, 0);
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
