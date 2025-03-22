using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public string _class;

    public void OnDrop(PointerEventData eventData)
    {
        eventData.pointerDrag.transform.position = transform.position;
        if(eventData.pointerDrag.transform.tag == "Soldier")
        {
            _class = "Soldier";
        }

        if (eventData.pointerDrag.transform.tag == "Wolf")
        {
            _class = "Wolf";
        }

        if (eventData.pointerDrag.transform.tag == "Mage")
        {
            _class = "Mage";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalculateWinner()
    {
        
        {

        }
    }
}
