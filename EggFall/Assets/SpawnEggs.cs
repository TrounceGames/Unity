using System;
using UnityEngine;
using System.Collections;

public class SpawnEggs : MonoBehaviour
{
    public GameObject Egg;
    public Transform trnsPos1;
    public Transform trnsPos2;
    public Transform trnsPos3;
    public Transform trnsPos4;
    public Transform trnsPos5;
    public Transform trnsPos6;
    private EggFall eggScript;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 1f, 3f);
        //CancelInvoke("Spawn");
        //   Spawn();

    }

    // Update is called once per frame
    void Spawn()
    {
        System.Random r = new System.Random();
        if (r.Next(1, 5) == 1)
        {
            GameObject obj = (GameObject)Instantiate(Egg, trnsPos1.position, Quaternion.identity);
            obj.transform.SetParent(trnsPos1);
        }
        else if (r.Next(1, 5) == 2)
        {
            GameObject obj6 = (GameObject)Instantiate(Egg, trnsPos6.position, Quaternion.identity);
            obj6.transform.SetParent(trnsPos6);
        }


        if (r.Next(1, 5) == 1)
        {
            GameObject obj2 = (GameObject)Instantiate(Egg, trnsPos2.position, Quaternion.identity);
            obj2.transform.SetParent(trnsPos2);
        }
        else if (r.Next(1, 5) == 2)
        {
            GameObject obj5 = (GameObject)Instantiate(Egg, trnsPos5.position, Quaternion.identity);
            obj5.transform.SetParent(trnsPos5);
        }


        if (r.Next(1, 5) == 1)
        {
            GameObject obj3 = (GameObject)Instantiate(Egg, trnsPos3.position, Quaternion.identity);
            obj3.transform.SetParent(trnsPos3);
        }
        else if (r.Next(1, 5) == 2)
        {
            GameObject obj4 = (GameObject)Instantiate(Egg, trnsPos4.position, Quaternion.identity);
            obj4.transform.SetParent(trnsPos4);
        }





    }
}
