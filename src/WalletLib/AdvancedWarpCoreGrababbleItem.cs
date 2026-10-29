using UnityEngine;

namespace WalletLib;

public class AdvancedWarpCoreGrabbableObject : GrabbableObject
{
    [SerializeField] private GameObject canvasRoot1;
    [SerializeField] private GameObject canvasRoot2;
    
    public override void PocketItem() 
    {
        base.PocketItem();
    
        canvasRoot1.SetActive(false);
        canvasRoot2.SetActive(false);

    }

    public override void EquipItem()
    {
        base.EquipItem();
    
        canvasRoot1.SetActive(true);
        canvasRoot2.SetActive(true);
    }
}
