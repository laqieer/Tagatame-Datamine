// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGPartyNameSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001724")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/Req/GvGPartyNameSet", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGvGPartyNameSet : FlowNode_Network
  {
    [Token(Token = "0x4005355")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005356")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005E3D")]
    [Address(RVA = "0x1329260", Offset = "0x1328060", VA = "0x11329260", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E3E")]
    [Address(RVA = "0x13298F0", Offset = "0x13286F0", VA = "0x113298F0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E3F")]
    [Address(RVA = "0x13294B0", Offset = "0x13282B0", VA = "0x113294B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E40")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGPartyNameSet()
    {
    }

    [Token(Token = "0x2001725")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005357")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGPartyNameSet.Response body;

      [Token(Token = "0x6005E41")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
