using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    public float _bill = 40;
    public float _tipRate = 20;
    private float _tipAmount;
    private float _total;



    // Start is called before the first frame update
    void Start()
    {
        CalculateTipAndTotal();
        Debug.Log($"Your bill is: {_bill} and your tip is: {_tipRate}%, so you owe: {_total}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CalculateTipAndTotal()
    {
        _tipAmount = (_tipRate / 100) * _bill;
        _total = _bill + _tipAmount;
    }
}
