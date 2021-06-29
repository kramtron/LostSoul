using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    bool attackBool = false;
    public float attackTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.playerController.attack == true)
        {
            attackTimer+=0.1f * Time.deltaTime;
            float x = GameObject.Find("Player").transform.position.x;
            float y = GameObject.Find("Player").transform.position.y;
            Vector3 position = new Vector3(x, y, 0);
            Quaternion rotation = new Quaternion();
            //Instantiate(,position, rotation); Falta poner el objeto
        }
        if (attackBool == true)
        {
            Destroy(gameObject);//Se destruye el collider del ataque
            PlayerController.playerController.attack = false;
            attackBool = false;
        }
        if (attackTimer == 0.75f)
        {
            attackBool = false;
            attackTimer = 0;
        }

        
    }
}
