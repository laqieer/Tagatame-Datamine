// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopCoinList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200238A")]
  [AddComponentMenu("UI/EventShopCoinList")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "イベントショップが押下された", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(2, "ArenaShopList - Off", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(3, "MultiShopList - Off", FlowNode.PinTypes.Input, 1)]
  public class EventShopCoinList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A03E")]
    private const int PIN_ID_REFRESH = 1;
    [Token(Token = "0x400A03F")]
    private const int PIN_INPUT_ADD_ARENA_SHOP_LIST_OFF = 2;
    [Token(Token = "0x400A040")]
    private const int PIN_INPUT_ADD_MULTI_SHOP_LIST_OFF = 3;
    [Token(Token = "0x400A041")]
    private const int PIN_ID_SHOPBTN = 101;
    [Token(Token = "0x400A042")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400A043")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ArenaTemplate;
    [Token(Token = "0x400A044")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject MultiTemplate;
    [Token(Token = "0x400A045")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ListExtras ScrollView;
    [Token(Token = "0x400A046")]
    [FieldOffset(Offset = "0x1C")]
    private List<GameObject> mEventCoinListItems;
    [Token(Token = "0x400A047")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsAddArenaShopList;
    [Token(Token = "0x400A048")]
    [FieldOffset(Offset = "0x21")]
    private bool mIsAddMultiShopList;

    [Token(Token = "0x60099A6")]
    [Address(RVA = "0x5DD920", Offset = "0x5DC720", VA = "0x105DD920")]
    private void ActivateOutputLinks(int pinID)
    {
    }

    [Token(Token = "0x60099A7")]
    [Address(RVA = "0x5DD930", Offset = "0x5DC730", VA = "0x105DD930", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60099A8")]
    [Address(RVA = "0x5DD970", Offset = "0x5DC770", VA = "0x105DD970")]
    private void Awake()
    {
    }

    [Token(Token = "0x60099A9")]
    [Address(RVA = "0x5DDB00", Offset = "0x5DC900", VA = "0x105DDB00")]
    private GameObject CreateListItem(EventCoinData eventcoin_data) => (GameObject) null;

    [Token(Token = "0x60099AA")]
    [Address(RVA = "0x5DDD90", Offset = "0x5DCB90", VA = "0x105DDD90")]
    private GameObject CreateOtherListItem(
      GameObject template,
      ListItemEvents.ListItemEvent func,
      bool is_button_enable)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60099AB")]
    [Address(RVA = "0x5DE320", Offset = "0x5DD120", VA = "0x105DE320")]
    private void UpdateItems()
    {
    }

    [Token(Token = "0x60099AC")]
    [Address(RVA = "0x5DDEC0", Offset = "0x5DCCC0", VA = "0x105DDEC0")]
    private List<ItemParam> GetDispCoins() => (List<ItemParam>) null;

    [Token(Token = "0x60099AD")]
    [Address(RVA = "0x5DE0F0", Offset = "0x5DCEF0", VA = "0x105DE0F0")]
    private void OnRefresh()
    {
    }

    [Token(Token = "0x60099AE")]
    [Address(RVA = "0x5DE1C0", Offset = "0x5DCFC0", VA = "0x105DE1C0")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x60099AF")]
    [Address(RVA = "0x5DE100", Offset = "0x5DCF00", VA = "0x105DE100")]
    private void OnSelectArenaShop(GameObject go)
    {
    }

    [Token(Token = "0x60099B0")]
    [Address(RVA = "0x5DE160", Offset = "0x5DCF60", VA = "0x105DE160")]
    private void OnSelectMultiShop(GameObject go)
    {
    }

    [Token(Token = "0x60099B1")]
    [Address(RVA = "0x5DE7C0", Offset = "0x5DD5C0", VA = "0x105DE7C0")]
    public EventShopCoinList()
    {
    }
  }
}
