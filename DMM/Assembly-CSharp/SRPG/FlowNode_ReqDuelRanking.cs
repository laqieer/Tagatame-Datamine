// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqDuelRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001350")]
  [FlowNode.NodeType("Duel/Req/DuelRanking", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(103, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(102, "DuplicateReqest", FlowNode.PinTypes.Output, 102)]
  public class FlowNode_ReqDuelRanking : FlowNode_Network
  {
    [Token(Token = "0x4004778")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004779")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400477A")]
    private const int PIN_OUT_DUPLICATE = 102;
    [Token(Token = "0x400477B")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 103;

    [Token(Token = "0x6005129")]
    [Address(RVA = "0x12600A0", Offset = "0x125EEA0", VA = "0x112600A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600512A")]
    [Address(RVA = "0x1260740", Offset = "0x125F540", VA = "0x11260740")]
    private void Success()
    {
    }

    [Token(Token = "0x600512B")]
    [Address(RVA = "0x1260270", Offset = "0x125F070", VA = "0x11260270", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600512C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqDuelRanking()
    {
    }

    [Token(Token = "0x2001351")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400477C")]
      [FieldOffset(Offset = "0x28")]
      public ReqDuelRanking.Response body;

      [Token(Token = "0x600512E")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
