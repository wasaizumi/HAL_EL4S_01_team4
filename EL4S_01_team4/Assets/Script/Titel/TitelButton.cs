using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitelButton : MonoBehaviour
{
    //移行するシーン::シーン名を入れてください
    [SerializeField]
    private string nextScene;

    private int time = 0;

    [SerializeField]
    private float x = -0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene(nextScene);
        }
        Vector3 pos = transform.position;
        pos.x += x;
        transform.position = pos;
        time++;
        if(time >= 30)
        {
            time = 0;
            x *= -1.0f;
        }
    }

    public void Onclick()
    {
        SceneManager.LoadScene(nextScene);
    }
}
