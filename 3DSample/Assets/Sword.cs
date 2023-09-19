using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    static public bool ShaveFlag = false;
    static public bool SwordFlag = false;

    public string targetName;
    public string hideName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)                 // “–‚½‚è”»’è‚ðŽ@’m
    {
        if (collision.gameObject.name == targetName)
        {
            GameObject hideObject = GameObject.Find(hideName);
            hideObject.SetActive(false);
        }
    }
}
