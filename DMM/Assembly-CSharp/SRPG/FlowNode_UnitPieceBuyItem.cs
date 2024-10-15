// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_UnitPieceBuyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001663")]
  [FlowNode.NodeType("System/Shop/UnitPieceBuyItem", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(104, "Not Exists Shop", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(105, "Purchased", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(106, "Item Limit", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(120, "Out of Period", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(121, "Refresh List", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(122, "Shop Out of Period", FlowNode.PinTypes.Output, 122)]
  [FlowNode.Pin(123, "Limit Over", FlowNode.PinTypes.Output, 123)]
  [AddComponentMenu("")]
  [FlowNode.Pin(124, "No Unit Party", FlowNode.PinTypes.Output, 124)]
  public class FlowNode_UnitPieceBuyItem : FlowNode_Network
  {
    [Token(Token = "0x4005158")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005159")]
    private const int PIN_OT_SUCCESS = 100;
    [Token(Token = "0x400515A")]
    private const int PIN_OT_NOT_EXISTS_SHOP = 104;
    [Token(Token = "0x400515B")]
    private const int PIN_OT_PURCHASED = 105;
    [Token(Token = "0x400515C")]
    private const int PIN_OT_ITEM_LIMIT = 106;
    [Token(Token = "0x400515D")]
    private const int PIN_OT_OUTOF_PERIOD = 120;
    [Token(Token = "0x400515E")]
    private const int PIN_OT_REFRESH_LIST = 121;
    [Token(Token = "0x400515F")]
    private const int PIN_OT_SHOP_OUTOF_PERIOD = 122;
    [Token(Token = "0x4005160")]
    private const int PIN_OT_LIMIT_OVER = 123;
    [Token(Token = "0x4005161")]
    private const int PIN_OT_NO_UNIT_PARTY = 124;

    [Token(Token = "0x6005BFC")]
    [Address(RVA = "0x13141B0", Offset = "0x1312FB0", VA = "0x113141B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BFD")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005BFE")]
    [Address(RVA = "0x1314400", Offset = "0x1313200", VA = "0x11314400", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005BFF")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_UnitPieceBuyItem()
    {
    }

    [Token(Token = "0x2001664")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005162")]
      [FieldOffset(Offset = "0x28")]
      public ReqUnitPieceShopBuypaid.Response body;

      [Token(Token = "0x6005C05")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
