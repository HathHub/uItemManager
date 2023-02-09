
using uScript.API.Attributes;
using System.Net;
using SDG.Unturned;
using uScript.Module.Main.Classes;

[ScriptModule("uItemManager")]
public class uItemManager
{
    [ScriptFunction("askClearAllItems")]
    public static void askClearAllItems()
    {
        ItemManager.askClearAllItems();
        
    }

    [ScriptFunction("askClearRegionItems")]
    public static void askClearRegionItems(byte x, byte y)
    {
        ItemManager.askClearRegionItems(x, y);

    }

    [ScriptFunction("ServerClearItemsInSphere")]
    public static void ServerClearItemsInSphere(Vector3Class position, float radius)
    {
        ItemManager.ServerClearItemsInSphere(position.Vector3, radius);

    }
}