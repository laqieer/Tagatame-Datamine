// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqWorldRaid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018AD")]
  [FlowNode.Pin(201, "Out of Period", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("WorldRaid/Req/WorldRaidTop", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqWorldRaid : FlowNode_Network
  {
    [Token(Token = "0x4005887")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005888")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005889")]
    private const int PIN_OUT_FAILED_OUTOFPERIOD = 201;

    [Token(Token = "0x600633D")]
    [Address(RVA = "0x315020", Offset = "0x313E20", VA = "0x10315020", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600633E")]
    [Address(RVA = "0x3155B0", Offset = "0x3143B0", VA = "0x103155B0")]
    private void Success()
    {
    }

    [Token(Token = "0x600633F")]
    [Address(RVA = "0x315120", Offset = "0x313F20", VA = "0x10315120", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006340")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqWorldRaid()
    {
    }

    [Token(Token = "0x20018AE")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400588A")]
      [FieldOffset(Offset = "0x28")]
      public ReqWorldRaid.Response body;

      [Token(Token = "0x6006342")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
