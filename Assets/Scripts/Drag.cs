using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    private Image _image;

    public void OnBeginDrag(PointerEventData eventData)
    {
        var temp = _image.color;
        temp.a = 0.5f;
        _image.color = temp;
        _image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var temp = _image.color;
        temp.a = 1;
        _image.color = temp;
        _image.raycastTarget = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
