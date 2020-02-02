using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogRotate : MonoBehaviour
{
    public float randnum;
    public GameObject Cogbrain;
    // Start is called before the first frame update
    void Start()
    {
        randnum = Random.Range(1.0f, 10.0f);
    }

    private void LateUpdate()
    {
        if (Cogbrain.GetComponent<FinalLevelComplete>().Particlesys.active == true && Cogbrain.GetComponent<FinalLevelComplete>().Particlesys2.active == true && Cogbrain.GetComponent<FinalLevelComplete>().Particlesys3.active == true)
        {
            if (randnum <= 5f)
            {
                gameObject.transform.Rotate(new Vector3(0f, 0f, 5f) * Time.deltaTime * 1.5f);
            }
            else
            {
                gameObject.transform.Rotate(new Vector3(0f, 0f, -5f) * Time.deltaTime * 1.5f);
            }
        }
    }
}
