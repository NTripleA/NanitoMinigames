using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomController : MonoBehaviour {

    public Inventory inventory;
    public int counter;

    public GameObject[] images;

    // Use this for initialization
    void Start() {

        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (inventory.getObjectName() == "Tent" || inventory.getObjectName() == "Socks" || inventory.getObjectName() == "Hockey stick")
        {
            //Poliacrilonitrilo
            if (counter == 0)
            {   
                if(inventory.getObjectName() == "Tent")
                {
                    images[20].SetActive(true);
                }
                else if(inventory.getObjectName() == "Socks")
                {
                    images[18].SetActive(true);
                }
                else
                {
                    images[13].SetActive(true);
                }
            }
            else if(counter == 1)
            {
                images[8].SetActive(true);
            }
            else
            {
                images[9].SetActive(true);
            }
        }
        else if (inventory.getObjectName() == "Blood")
        {
            // DNA
            if(counter == 0)
            {
                images[10].SetActive(true);
            }
            else if(counter == 1)
            {
                images[4].SetActive(true);
            }
            else
            {
                images[5].SetActive(true);
            }

        }
        else if (inventory.getObjectName() == "Contact lens" || inventory.getObjectName() == "Pill" || inventory.getObjectName() == "Plexiglass")
        {
            //poli que se yo que de metilo
            if (counter == 0)
            {
                if (inventory.getObjectName() == "Contact lens")
                {
                    images[11].SetActive(true);
                }
                else if (inventory.getObjectName() == "Pill")
                {
                    images[15].SetActive(true);
                }
                else
                {
                    images[16].SetActive(true);
                }
            }
            else if (counter == 1)
            {
                images[6].SetActive(true);
            }
            else
            {
                images[7].SetActive(true);
            }
        }
        else if (inventory.getObjectName() == "neumatico" || inventory.getObjectName() == "Salvavidas")
        {
            // Algoon
            if (counter == 0)
            {
                if (inventory.getObjectName() == "neumatico")
                {
                    images[14].SetActive(true);
                }
                else
                {
                    images[17].SetActive(true);
                }
            }
            else if (counter == 1)
            {
                images[0].SetActive(true);
            }
            else
            {
                images[1].SetActive(true);
            }
        }
        else if (inventory.getObjectName() == "Sole" || inventory.getObjectName() == "Eraser")
        {
            //caucho
            if (counter == 0)
            {
                if (inventory.getObjectName() == "Sole")
                {
                    images[19].SetActive(true);
                }
                else
                {
                    images[12].SetActive(true);
                }
            }
            else if (counter == 1)
            {
                images[2].SetActive(true);
            }
            else
            {
                images[3].SetActive(true);
            }
        }
    }

    public void addCounter()
    {
        if(counter != 2)
        {
            counter++;
        }
    }

    public void decCounter()
    {
        if(counter != 0)
        {
            counter--;
        }
    }

    public void setAllInactive()
    {
        for(int i=0; i < images.Length; i++)
        {
            images[i].SetActive(false);
        }
    }
}