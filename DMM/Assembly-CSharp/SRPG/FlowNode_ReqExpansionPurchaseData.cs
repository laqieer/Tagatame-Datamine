// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqExpansionPurchaseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200135C")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(10, "Request", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("ExpansionPurchase/ReqExpansionPurchaseData", 32741)]
  public class FlowNode_ReqExpansionPurchaseData : FlowNode_Network
  {
    [Token(Token = "0x4004797")]
    private const int PIN_IN_REQUEST = 10;
    [Token(Token = "0x4004798")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005145")]
    [Address(RVA = "0x1276BD0", Offset = "0x12759D0", VA = "0x11276BD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005146")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005147")]
    [Address(RVA = "0x1276C90", Offset = "0x1275A90", VA = "0x11276C90", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005148")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqExpansionPurchaseData()
    {
    }

    [Token(Token = "0x200135D")]
    [MessagePackObject(true)]
    public class MP_ReqExpansionPurchaseResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004799")]
      [FieldOffset(Offset = "0x28")]
      public ReqExpansionPurchase.Response body;

      [Token(Token = "0x6005149")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_ReqExpansionPurchaseResponse()
      {
      }
    }
  }
}
