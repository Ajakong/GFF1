
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

 

public class BossState : MonoBehaviour

{

    public GameObject Item;

    GameObject Drop;

    private int Hp = 0;

    // Start is called before the first frame update

    void Start()

    {


    }



    // Update is called once per frame

    void Update()

    {

        if (Hp == 0)

        {



            Drop = Instantiate(Item);

            Drop.transform.position = transform.position;

            Destroy(gameObject);

        }

    }

}
