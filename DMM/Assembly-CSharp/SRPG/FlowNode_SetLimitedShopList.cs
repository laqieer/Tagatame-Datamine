// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetLimitedShopList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200161D")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Shop/SetLimitedShopList", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "IsLimitedShop", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(131, "ポートショップ：ギルド未所属", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_SetLimitedShopList : FlowNode_Network
  {
    [Token(Token = "0x4005029")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400502A")]
    private const int PIN_IN_IS_LIMITED_SHOP = 2;
    [Token(Token = "0x400502B")]
    private const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x400502C")]
    private const int PIN_OUT_PORTSHOP_GUILD_NOTJOINED = 131;
    [Token(Token = "0x400502D")]
    [FieldOffset(Offset = "0x20")]
    public LimitedShopList limited_shop_list;
    [Token(Token = "0x400502E")]
    [FieldOffset(Offset = "0x24")]
    private int inputPin;

    [Token(Token = "0x6005AF1")]
    [Address(RVA = "0x12FAA10", Offset = "0x12F9810", VA = "0x112FAA10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005AF2")]
    [Address(RVA = "0x12FAB50", Offset = "0x12F9950", VA = "0x112FAB50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005AF3")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    public void Success()
    {
    }

    [Token(Token = "0x6005AF4")]
    [Address(RVA = "0x12FA770", Offset = "0x12F9570", VA = "0x112FA770")]
    private void EraseTimeOutPopupHistory(string warned_key, JSON_ShopListArray.Shops[] shops)
    {
    }

    [Token(Token = "0x6005AF5")]
    [Address(RVA = "0x12FB3D0", Offset = "0x12FA1D0", VA = "0x112FB3D0")]
    public FlowNode_SetLimitedShopList()
    {
    }
  }
}
