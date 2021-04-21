using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

 

public class GameManager : MonoBehaviour

{

  

    private void Start ()

    {

    }

 

    private void Update ()

    {

    }

}

// Fungsi System.Serializable adalah agar object bisa di-serialize dan

// value dapat di-set dari inspector

[System.Serializable]

public struct ResourceConfig

{

    public string Name;

    public double UnlockCost;

    public double UpgradeCost;

    public double Output;

}