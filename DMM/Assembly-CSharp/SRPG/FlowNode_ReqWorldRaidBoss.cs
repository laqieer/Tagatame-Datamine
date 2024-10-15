// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqWorldRaidBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018AF")]
  [FlowNode.NodeType("WorldRaid/Req/WorldRaidBoss", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "Reload Top", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "Out of Period", FlowNode.PinTypes.Output, 202)]
  [AddComponentMenu("")]
  public class FlowNode_ReqWorldRaidBoss : FlowNode_Network
  {
    [Token(Token = "0x400588B")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400588C")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400588D")]
    private const int PIN_OUT_RELOAD_TOP = 201;
    [Token(Token = "0x400588E")]
    private const int PIN_OUT_FAILED_OUTOFPERIOD = 202;

    [Token(Token = "0x6006343")]
    [Address(RVA = "0x3138B0", Offset = "0x3126B0", VA = "0x103138B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006344")]
    [Address(RVA = "0x313E10", Offset = "0x312C10", VA = "0x10313E10")]
    private void Success()
    {
    }

    [Token(Token = "0x6006345")]
    [Address(RVA = "0x313A30", Offset = "0x312830", VA = "0x10313A30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006346")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqWorldRaidBoss()
    {
    }

    [Token(Token = "0x20018B0")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400588F")]
      [FieldOffset(Offset = "0x28")]
      public ReqWorldRaidBoss.Response body;

      [Token(Token = "0x6006348")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
