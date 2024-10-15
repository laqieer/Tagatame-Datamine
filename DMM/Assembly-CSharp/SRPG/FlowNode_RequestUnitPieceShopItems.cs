// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RequestUnitPieceShopItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015CF")]
  [FlowNode.NodeType("System/Shop/RequestUnitPieceShopItems", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_RequestUnitPieceShopItems : FlowNode_Network
  {
    [Token(Token = "0x4004F52")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004F53")]
    private const int PIN_OUT_SUCCESS = 10;

    [Token(Token = "0x60059AB")]
    [Address(RVA = "0x12EAE90", Offset = "0x12E9C90", VA = "0x112EAE90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60059AC")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x60059AD")]
    [Address(RVA = "0x12EAF60", Offset = "0x12E9D60", VA = "0x112EAF60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60059AE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_RequestUnitPieceShopItems()
    {
    }

    [Token(Token = "0x20015D0")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004F54")]
      [FieldOffset(Offset = "0x28")]
      public ReqUnitPieceShopItemList.Response body;

      [Token(Token = "0x60059AF")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
