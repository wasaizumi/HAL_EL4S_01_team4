using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitelQuit : MonoBehaviour
{
    private int time = 0;

    [SerializeField]
    private float x = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Application.Quit();
        }
        Vector3 pos = transform.position;
        pos.x += x;
        transform.position = pos;
        time++;
        if (time >= 30)
        {
            time = 0;
            x *= -1.0f;
        }
    }
    public void Onclick()
    {
        Application.Quit();
    }
}
