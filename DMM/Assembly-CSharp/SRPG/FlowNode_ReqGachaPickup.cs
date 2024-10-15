// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGachaPickup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200167A")]
  [AddComponentMenu("")]
  [FlowNode.Pin(23, "NotPickupItems", FlowNode.PinTypes.Output, 23)]
  [FlowNode.Pin(21, "NoGacha", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(22, "NotPickupSelect", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("System/Gacha/Pickup", 32741)]
  [FlowNode.Pin(20, "NotSetGachaId", FlowNode.PinTypes.Output, 20)]
  public class FlowNode_ReqGachaPickup : FlowNode_Network
  {
    [Token(Token = "0x40051C3")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40051C4")]
    private const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x40051C5")]
    private const int PIN_OUT_NOT_SET_GACHAID = 20;
    [Token(Token = "0x40051C6")]
    private const int PIN_OUT_NOGACHA = 21;
    [Token(Token = "0x40051C7")]
    private const int PIN_OUT_NOT_PICKUP_SELECT = 22;
    [Token(Token = "0x40051C8")]
    private const int PIN_OUT_NOT_PICKUP_ITEMS = 23;
    [Token(Token = "0x40051C9")]
    [FieldOffset(Offset = "0x20")]
    private string select_gachaid;

    [Token(Token = "0x6005C48")]
    [Address(RVA = "0x1309940", Offset = "0x1308740", VA = "0x11309940", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C49")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005C4A")]
    [Address(RVA = "0x1309BB0", Offset = "0x13089B0", VA = "0x11309BB0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005C4B")]
    [Address(RVA = "0x1309F70", Offset = "0x1308D70", VA = "0x11309F70")]
    public FlowNode_ReqGachaPickup()
    {
    }

    [Token(Token = "0x200167B")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40051CA")]
      [FieldOffset(Offset = "0x28")]
      public ReqGachaPickup.Response body;

      [Token(Token = "0x6005C4C")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
