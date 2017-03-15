using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomsManager : MonoBehaviour {


    public GameObject infoCafe;
    public GameObject infoCanela;
    public GameObject infoChocolate;
    public GameObject infoEtanol;
    public GameObject infoGlucosa;
    public GameObject infosintetico;
    public GameObject infonatural;
    public GameObject infosemisintetico;
    public GameObject NanitoEscoge;
    public GameObject polymerscat;
    public GameObject syntheticcat;
    public GameObject naturalcat;
    public GameObject semisinthetyccat;
    public GameObject barra;
  
    //Botones de Categorias

    public void polymercatButton()
    {
        Debug.Log("undi la carta semisintetico");
        polymerscat.SetActive(true);
        syntheticcat.SetActive(false);
        naturalcat.SetActive(false);
        semisinthetyccat.SetActive(false);
        NanitoEscoge.SetActive(false);
        barra.SetActive(true);
    }
    public void syntheticcatButton()
    {
        Debug.Log("undi la carta semisintetico");
        syntheticcat.SetActive(true);
        polymerscat.SetActive(false);
        naturalcat.SetActive(false);
        semisinthetyccat.SetActive(false);
        NanitoEscoge.SetActive(false);
        barra.SetActive(false);
    }
    public void naturalcatButton()
    {
        Debug.Log("undi la carta semisintetico");
        naturalcat.SetActive(true);
        polymerscat.SetActive(false);
        syntheticcat.SetActive(false);
        semisinthetyccat.SetActive(false);
        NanitoEscoge.SetActive(false);
        barra.SetActive(false);
    }
    public void semisinthetyccatButton()
    {
        Debug.Log("undi la carta semisintetico");
        semisinthetyccat.SetActive(true);
        polymerscat.SetActive(false);
        syntheticcat.SetActive(false);
        naturalcat.SetActive(false);
        NanitoEscoge.SetActive(false);
        barra.SetActive(false);
    }

    //Botones Polimeros para Informacion

    public void cafeButton()
    {
        Debug.Log("undi la carta cafe");
        infoCafe.SetActive(true);
    }

    public void canelaButton()
    {
        Debug.Log("undi la carta canela");
        infoCanela.SetActive(true);
    }
    public void chocoButton()
    {
        Debug.Log("undi la carta choco");
        infoChocolate.SetActive(true);
    }
    public void etanolButton()
    {
        Debug.Log("undi la carta etanol");
        infoEtanol.SetActive(true);
    }
    public void glucosaButton()
    {
        Debug.Log("undi la carta glucosa");
        infoGlucosa.SetActive(true);
    }
    public void sinteticoButton()
    {
        Debug.Log("undi la carta sintetico");
        infosintetico.SetActive(true);
    }
    public void naturalButton()
    {
        Debug.Log("undi la carta natural");
        infonatural.SetActive(true);
    }
    public void semisinteticoButton()
    {
        Debug.Log("undi la carta semisintetico");
        infosemisintetico.SetActive(true);
    }

    // Boton para desactivar imagenes de informacion
    public void journalmainbutton()
    {
        Debug.Log("undi la carta journalmainbutton");
        infoCafe.SetActive(false);
        infoCanela.SetActive(false);
        infoChocolate.SetActive(false);
        infoEtanol.SetActive(false);
        infoGlucosa.SetActive(false);
        infosemisintetico.SetActive(false);
        infonatural.SetActive(false);
        infosintetico.SetActive(false);
        syntheticcat.SetActive(false);
        polymerscat.SetActive(false);
        naturalcat.SetActive(false);
        semisinthetyccat.SetActive(false);
        NanitoEscoge.SetActive(true);
        barra.SetActive(false);

    }
}
