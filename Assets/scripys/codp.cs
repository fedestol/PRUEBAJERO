using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codp : MonoBehaviour
{


    public int dias;
    public string codigo;
    // Start is called before the first frame update
    void Start()
    {
        int gr = 0;
        int res;
        int cost = 0;

        if (codigo == "G")

        {
            gr = 300;
        }


        else if (codigo == "PP")

        {
            gr = 400;
        }

        else if (codigo == "GP")

        {
            gr = 700;
        }

        res = gr * dias;

        Debug.Log("Para ese período se necesitan  " + gr);

        cost = (gr / 100) * 80;

        Debug.Log("El total a pagar es de:" + cost);

        if (dias < 3)

        {
            Debug.Log("No se puede ingresar una cantidad de dias menor a tres");
        }

        if (codigo != "GP"|| codigo  != "G" || codigo != "P") ;

        {
            Debug.Log("El codigo no es valido");
        }

        

















    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
