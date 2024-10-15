// Decompiled with JetBrains decompiler
// Type: SRPG.ItemList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200265B")]
  [FlowNode.Pin(110, "全アイテム表示", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "アイテムリセット", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(150, "装備スロット解除", FlowNode.PinTypes.Input, 150)]
  [AddComponentMenu("SRPG/UI/アイテムリスト")]
  [FlowNode.Pin(111, "回復アイテム表示", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(101, "アイテム決定", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(112, "攻撃アイテム表示", FlowNode.PinTypes.Input, 12)]
  public class ItemList : SRPG_ListBase, IFlowInterface
  {
    [Token(Token = "0x400B361")]
    [FieldOffset(Offset = "0x20")]
    private ItemData[] mInventoryCache;
    [Token(Token = "0x400B362")]
    [FieldOffset(Offset = "0x0")]
    public static ItemData SelectedItem;
    [Token(Token = "0x400B363")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400B364")]
    [FieldOffset(Offset = "0x28")]
    public ItemList.ItemFilters Filter;

    [Token(Token = "0x600AB4A")]
    [Address(RVA = "0x6E82B0", Offset = "0x6E70B0", VA = "0x106E82B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AB4B")]
    [Address(RVA = "0x6E8430", Offset = "0x6E7230", VA = "0x106E8430")]
    private void InventoryChanged()
    {
    }

    [Token(Token = "0x600AB4C")]
    [Address(RVA = "0x6E8860", Offset = "0x6E7660", VA = "0x106E8860")]
    private void ResetInventory()
    {
    }

    [Token(Token = "0x600AB4D")]
    [Address(RVA = "0x6E8340", Offset = "0x6E7140", VA = "0x106E8340")]
    private void CacheInventory()
    {
    }

    [Token(Token = "0x600AB4E")]
    [Address(RVA = "0x6E8970", Offset = "0x6E7770", VA = "0x106E8970", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600AB4F")]
    [Address(RVA = "0x6E8650", Offset = "0x6E7450", VA = "0x106E8650")]
    private void RefreshItems()
    {
    }

    [Token(Token = "0x600AB50")]
    [Address(RVA = "0x6E8060", Offset = "0x6E6E60", VA = "0x106E8060", Slot = "9")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AB51")]
    [Address(RVA = "0x6E8490", Offset = "0x6E7290", VA = "0x106E8490")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600AB52")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnOpenDetail(GameObject go)
    {
    }

    [Token(Token = "0x600AB53")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnCloseDetail(GameObject go)
    {
    }

    [Token(Token = "0x600AB54")]
    [Address(RVA = "0x6E8C40", Offset = "0x6E7A40", VA = "0x106E8C40")]
    public ItemList()
    {
    }

    [Token(Token = "0x200265C")]
    public enum ItemFilters
    {
      [Token(Token = "0x400B366")] All,
      [Token(Token = "0x400B367")] Potions,
      [Token(Token = "0x400B368")] Offensive,
    }
  }
}
