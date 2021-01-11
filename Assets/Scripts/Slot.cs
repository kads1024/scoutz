using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{
    public GameObject Item;
    public GameObject Next;

    public string parentItem;
    public StakeCounter counter;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag == Item || eventData.pointerDrag.transform.parent.name.Contains(parentItem))
        {
            eventData.pointerDrag.transform.SetParent(gameObject.transform.parent);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            if(gameObject.name.Contains("StakeSlot") || gameObject.name.Contains("Stick") || gameObject.name.Contains("Rope"))
            {
                Destroy(eventData.pointerDrag);
            }
            eventData.pointerDrag.GetComponent<Image>().raycastTarget = false;
            Next?.SetActive(true);
            if(counter!=null)
            {
                counter.count++;
            }
            Destroy(gameObject);
        }
    }

  
}
