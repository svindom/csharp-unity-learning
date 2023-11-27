using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank 
{
    protected string branchName;
    protected string location;
    protected int cashInVault;

    // protected means that only inheritanced classes can access it.
    protected void CheckBalance()
    {
        Debug.Log($"Checking Balance: {branchName}");
    }

    protected void Withdraw()
    {
        Debug.Log($"Withdrawing Money from: {branchName}");
    }

    protected void Deposit()
    {
        Debug.Log($"Deposing Money to: {branchName}");
    }

}
