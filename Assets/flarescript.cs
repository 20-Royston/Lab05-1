using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flarescript : MonoBehaviour
{


    // Start is called before the first frame update
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
