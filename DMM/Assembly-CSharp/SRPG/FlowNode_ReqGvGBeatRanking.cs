// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGBeatRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001706")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/Req/GvGBeatRanking", 32741)]
  public class FlowNode_ReqGvGBeatRanking : FlowNode_Network
  {
    [Token(Token = "0x4005312")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005313")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005DDD")]
    [Address(RVA = "0x1323E90", Offset = "0x1322C90", VA = "0x11323E90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DDE")]
    [Address(RVA = "0x1324590", Offset = "0x1323390", VA = "0x11324590")]
    private void Success()
    {
    }

    [Token(Token = "0x6005DDF")]
    [Address(RVA = "0x13240E0", Offset = "0x1322EE0", VA = "0x113240E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005DE0")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGBeatRanking()
    {
    }

    [Token(Token = "0x2001707")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005314")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGBeatRanking.Response body;

      [Token(Token = "0x6005DE1")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
