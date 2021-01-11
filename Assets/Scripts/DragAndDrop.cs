using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    private Vector2 startPos;
    private bool isBeingHeld;
    private Camera cam;

    public Transform Drop;
    public GameObject Next;

    public Vector3 OrigPos;
    public Canvas canvas;
    RectTransform rt;
    public CanvasGroup cg;
    private void Awake()
    {
        cam = Camera.main;
        rt = GetComponent<RectTransform>();
        cg = GetComponent<CanvasGroup>();
    }

    // Start is called before the first frame update
    void Start()
    {
        isBeingHeld = false;
        OrigPos = rt.anchoredPosition;
    }

  

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        cg.alpha = 0.6f;
        cg.blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        cg.alpha = 1f;
        cg.blocksRaycasts = true;
        if (gameObject.name.Contains("Logo"))
        {
            Destroy(gameObject);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        rt.anchoredPosition += eventData.delta / canvas.scaleFactor;

        
    }

    public void OnDrop(PointerEventData eventData)
    {
        
    }
}
