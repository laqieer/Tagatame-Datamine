// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetEventShopList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001611")]
  [FlowNode.Pin(2, "IsEventShop", FlowNode.PinTypes.Input, 3)]
  [FlowNode.NodeType("System/Shop/SetEventShopList", 32741)]
  [FlowNode.Pin(3, "ArenaShopList - Off", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(4, "MultiShopList - Off", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_SetEventShopList : FlowNode_Network
  {
    [Token(Token = "0x4005001")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005002")]
    private const int PIN_IN_IS_EVENT_SHOP = 2;
    [Token(Token = "0x4005003")]
    private const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x4005004")]
    private const int PIN_INPUT_ADD_ARENA_SHOP_LIST_OFF = 3;
    [Token(Token = "0x4005005")]
    private const int PIN_INPUT_ADD_MULTI_SHOP_LIST_OFF = 4;
    [Token(Token = "0x4005006")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_SetEventShopList.Mode mode;
    [Token(Token = "0x4005007")]
    [FieldOffset(Offset = "0x24")]
    public EventShopList event_shop_list;
    [Token(Token = "0x4005008")]
    [FieldOffset(Offset = "0x28")]
    private int inputPin;
    [Token(Token = "0x4005009")]
    [FieldOffset(Offset = "0x2C")]
    private bool mIsAddArenaShopList;
    [Token(Token = "0x400500A")]
    [FieldOffset(Offset = "0x2D")]
    private bool mIsAddMultiShopList;

    [Token(Token = "0x6005AD4")]
    [Address(RVA = "0x12F9590", Offset = "0x12F8390", VA = "0x112F9590", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005AD5")]
    [Address(RVA = "0x12F96C0", Offset = "0x12F84C0", VA = "0x112F96C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005AD6")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    public void Success()
    {
    }

    [Token(Token = "0x6005AD7")]
    [Address(RVA = "0x12F92D0", Offset = "0x12F80D0", VA = "0x112F92D0")]
    private void EraseTimeOutPopupHistory(JSON_ShopListArray.Shops[] shops)
    {
    }

    [Token(Token = "0x6005AD8")]
    [Address(RVA = "0x12F9E50", Offset = "0x12F8C50", VA = "0x112F9E50")]
    public FlowNode_SetEventShopList()
    {
    }

    [Token(Token = "0x2001612")]
    private enum Mode
    {
      [Token(Token = "0x400500C")] GetShopList,
      [Token(Token = "0x400500D")] GetCoinNum,
    }

    [Token(Token = "0x2001613")]
    private class JSON_CoinNum
    {
      [Token(Token = "0x400500E")]
      [FieldOffset(Offset = "0x8")]
      public Json_Item[] item;
      [Token(Token = "0x400500F")]
      [FieldOffset(Offset = "0xC")]
      public FlowNode_SetEventShopList.JSON_NewCoin newcoin;

      [Token(Token = "0x6005AD9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_CoinNum()
      {
      }
    }

    [Token(Token = "0x2001614")]
    private class JSON_NewCoin
    {
      [Token(Token = "0x4005010")]
      [FieldOffset(Offset = "0x8")]
      public long period;

      [Token(Token = "0x6005ADA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_NewCoin()
      {
      }
    }
  }
}
