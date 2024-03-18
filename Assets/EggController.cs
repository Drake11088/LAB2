using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EggController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject EggBroken;
    public GameObject Egg;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name.Equals("dat"))
        {
            Instantiate(EggBroken, transform.position, quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if(col.gameObject.name.Equals("Egg"))
        {
            Instantiate(EggBroken, transform.position, quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if(col.gameObject.name.Equals("Famer"))
        {
            Instantiate(EggBroken, transform.position, quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if(col.gameObject.name.Equals("Box"))
        {
            Instantiate(EggBroken, transform.position, quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }    
    }
}
