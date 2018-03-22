using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCon : MonoBehaviour {
    public float bulletSpeed;

	// Use this for initialization
	void Start () {

        bulletSpeed = bulletSpeed * 540;
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, 1 * bulletSpeed * Time.deltaTime, 0);

        if (transform.position.y > 555f)
        {
            Destroy(gameObject);
        }
		
	}
}
