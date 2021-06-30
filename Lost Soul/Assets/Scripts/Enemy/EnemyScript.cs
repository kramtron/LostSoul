using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    bool nearPlayer = false;
    public float seeingDistance = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = GameObject.Find("Player").transform.position.x; //trobar la x del player
        float y = GameObject.Find("Player").transform.position.y; //trobar la y del player
        Vector3 Playerposition = new Vector3(x, y, 0); //posar-ho en un vector

        //distància del player a l'enemic (pitàgores c2 + c2 = h2)
        if (Mathf.Sqrt(Mathf.Pow(gameObject.transform.position.x - Playerposition.x, 2) + 
                       Mathf.Pow(gameObject.transform.position.y - Playerposition.y, 2)) < seeingDistance)
        {
            nearPlayer = true;
        }
        else
        {
            nearPlayer = false;
        }

        //En distància
        if (nearPlayer)
        {
           // gameObject.transform.Translate(0, -5f * Time.deltaTime, 0);
        }
        else
        {
            gameObject.transform.Translate(0, -5f * Time.deltaTime, 0); //es mou cap avall si t'hi apropes
            //falta posar un timer perque vagi d'esquerra a dreta o algo
        }
    }
}
