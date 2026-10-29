using UnityEngine;

namespace WalletLib;

public class SimpleWarpCoreGrabbableObject : GrabbableObject
{
    [SerializeField] private GameObject canvasRoot;
    
    public override void PocketItem() 
    {
        base.PocketItem();
    
        canvasRoot.SetActive(false);
    }

    public override void EquipItem()
    {
        base.EquipItem();

        canvasRoot.SetActive(true);
    }
}
