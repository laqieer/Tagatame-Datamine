// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqHotDealStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001318")]
  [AddComponentMenu("")]
  [FlowNode.Pin(110, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "Request", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("HotDeal/Req/HotDealStart", 32741)]
  public class FlowNode_ReqHotDealStart : FlowNode_Network
  {
    [Token(Token = "0x40046DB")]
    private const int PIN_INPUT_REQUEST = 10;
    [Token(Token = "0x40046DC")]
    private const int PIN_OUTPUT_SUCCESS = 100;
    [Token(Token = "0x40046DD")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 110;

    [Token(Token = "0x6005087")]
    [Address(RVA = "0x12621E0", Offset = "0x1260FE0", VA = "0x112621E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005088")]
    [Address(RVA = "0x1262360", Offset = "0x1261160", VA = "0x11262360", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005089")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqHotDealStart()
    {
    }

    [Token(Token = "0x2001319")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40046DE")]
      [FieldOffset(Offset = "0x28")]
      public ReqHotDealStart.Response body;

      [Token(Token = "0x600508B")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
