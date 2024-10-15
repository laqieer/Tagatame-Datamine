// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqHotDealConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001314")]
  [FlowNode.Pin(10, "Request", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(110, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("BuyCoin/HotDeal/confirm_badge", 32741)]
  public class FlowNode_ReqHotDealConfirm : FlowNode_Network
  {
    [Token(Token = "0x40046D3")]
    private const int PIN_INPUT_REQUEST = 10;
    [Token(Token = "0x40046D4")]
    private const int PIN_OUTPUT_SUCCESS = 100;
    [Token(Token = "0x40046D5")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 110;

    [Token(Token = "0x600507D")]
    [Address(RVA = "0x1261840", Offset = "0x1260640", VA = "0x11261840", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600507E")]
    [Address(RVA = "0x12619B0", Offset = "0x12607B0", VA = "0x112619B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600507F")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqHotDealConfirm()
    {
    }

    [Token(Token = "0x2001315")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40046D6")]
      [FieldOffset(Offset = "0x28")]
      public ReqHotDealConfirm.Response body;

      [Token(Token = "0x6005081")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
