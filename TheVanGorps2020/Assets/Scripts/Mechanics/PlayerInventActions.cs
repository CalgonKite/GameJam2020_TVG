using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventActions : MonoBehaviour
{

    public Inventory invent;
    public Image currentCog;

    // Start is called before the first frame update
    void Start()
    {
        invent = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (invent.CurrentItem.Count > 0)
        {
            currentCog.gameObject.SetActive(true);
            currentCog.sprite = invent.CurrentItem[0].Icon;
        }else { currentCog.gameObject.SetActive(false);  }

        if (Input.GetKeyDown("g"))
        {
            invent.DropItem();
        }
    }
}