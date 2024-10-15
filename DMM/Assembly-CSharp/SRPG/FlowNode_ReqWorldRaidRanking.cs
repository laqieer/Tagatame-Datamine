// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqWorldRaidRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018B1")]
  [AddComponentMenu("")]
  [FlowNode.Pin(102, "DuplicationRequest", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("WorldRaid/Req/WorldRaidRanking", 32741)]
  [FlowNode.Pin(201, "Out of Period", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqWorldRaidRanking : FlowNode_Network
  {
    [Token(Token = "0x4005890")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005891")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005892")]
    private const int PIN_OUT_DUPLICATION_REQUEST = 102;
    [Token(Token = "0x4005893")]
    private const int PIN_OUT_FAILED_OUTOFPERIOD = 201;

    [Token(Token = "0x6006349")]
    [Address(RVA = "0x313EA0", Offset = "0x312CA0", VA = "0x10313EA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600634A")]
    [Address(RVA = "0x314540", Offset = "0x313340", VA = "0x10314540")]
    private void Success()
    {
    }

    [Token(Token = "0x600634B")]
    [Address(RVA = "0x3140E0", Offset = "0x312EE0", VA = "0x103140E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600634C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqWorldRaidRanking()
    {
    }

    [Token(Token = "0x20018B2")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005894")]
      [FieldOffset(Offset = "0x28")]
      public ReqWorldRaidRanking.Response body;

      [Token(Token = "0x600634E")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
