using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        gameObject.transform.parent.Translate(0, -5f * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            Destroy(transform.parent.gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            Debug.Log("A");
            Destroy(transform.parent.gameObject);
            LifeManager.lifeManager.RaiseLife(1);
        }
    }
}
