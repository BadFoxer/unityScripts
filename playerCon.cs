using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCon : MonoBehaviour
{

    public float Speed;
    public float H;
    public Transform bullet;
    public Transform bulletPointL;
    public Transform bulletPointR;
    public float waitForShoot;
    public float timer;

    // Use this for initialization
    void Start()
    {
        Speed = Speed * 540;
        timer = 0;
        waitForShoot = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
        
            if (timer <= 0f) {
                Instantiate(bullet, bulletPointL.position, Quaternion.identity);
                Instantiate(bullet, bulletPointR.position, Quaternion.identity);
                timer = waitForShoot;
               
            }
     
        }

        H = Input.GetAxis("Horizontal") * Speed;

        transform.Translate(H * Time.deltaTime, 0, 0);

    }
}



