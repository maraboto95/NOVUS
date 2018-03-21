using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot_enlaces : MonoBehaviour, IDropHandler {

   

    public int valencia;

    GameObject itemValencia;

    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }

    }



    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            if (this.gameObject == GameObject.FindGameObjectWithTag("Basura"))
            {
                Destroy(DragHandeler_enlaces.itemBeingDragged);
            }
            else
            {

                if ((DragHandeler_enlaces.itemBeingDragged.tag == "Dot" && (this.gameObject.tag == "Dot_L" || this.gameObject.tag == "Dot_U" ||
                    this.gameObject.tag == "Dot_M" || this.gameObject.tag == "Dot_R" || this.gameObject.tag == "Dot_D")) ||
                    (DragHandeler_enlaces.itemBeingDragged.tag != "Dot" && (this.gameObject.tag != "Dot_L" && this.gameObject.tag != "Dot_U" &&
                    this.gameObject.tag != "Dot_M" && this.gameObject.tag != "Dot_R" && this.gameObject.tag != "Dot_D")))
                {
                    DragHandeler_enlaces.itemBeingDragged.transform.SetParent(transform);

                }

                if(DragHandeler_enlaces.itemBeingDragged.tag == "Dot")
                {
                    
                        if (this.tag == "Dot_M")
                        {
                            DragHandeler_enlaces.itemBeingDragged.GetComponent<Image>().color = Color.blue;
                        }
                        else if(this.tag != "Dot_M")
                        {
                            DragHandeler_enlaces.itemBeingDragged.GetComponent<Image>().color = Color.green;
                        }
                    
                }

            }

        }

    }


   

   



}//class

