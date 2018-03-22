using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgEndless : MonoBehaviour
{

    public float bgSpeed; // levelio scrolling greiti galite pasikeisti unity editoriuje
    public Vector2 starPos; // startinis levelio vektorius
    public float bossTime;
    public bool fight;

    // Use this for initialization
    void Start()
    {

        starPos = transform.position; // startPos priskiriam transform position kuri galime matyti unity editoriuje
        starPos = new Vector2(0, 0); // priskiriam startine levelio pozicija nuo kurios prades judeti
        bgSpeed = bgSpeed * 540f;
        bossTime = 0f;
        fight = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!fight)
        {
            bossTime += Time.deltaTime;
        }

        if (fight)
        {
            bgSpeed += 1f;

            if (bgSpeed >= 540f)
            {
                bgSpeed = 540f;
            }
        }

        transform.Translate(0, 1 * -bgSpeed * Time.deltaTime, 0); // judam i virsu

        if (transform.position.y < -1080f) // jeigu pozicija y yra mažiau nei -1081f 
        {
            transform.position = starPos; // judejimo pozicija lygi startinei pozicijai
        }
        if (bossTime >= 3f)
        {
            bgSpeed -= 1f;
            if (bgSpeed < -0f)
            {
                fight = true;
                bossTime = 0f;
                bgSpeed = 0;

            }

        }
    }
}
       


