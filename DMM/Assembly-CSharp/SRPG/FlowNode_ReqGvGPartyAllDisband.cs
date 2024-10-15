// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGPartyAllDisband
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001721")]
  [FlowNode.NodeType("GvG/Req/GvGPartyAllDisband", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGvGPartyAllDisband : FlowNode_Network
  {
    [Token(Token = "0x4005350")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005351")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005E35")]
    [Address(RVA = "0x1328C10", Offset = "0x1327A10", VA = "0x11328C10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E36")]
    [Address(RVA = "0x13291F0", Offset = "0x1327FF0", VA = "0x113291F0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E37")]
    [Address(RVA = "0x1328D20", Offset = "0x1327B20", VA = "0x11328D20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E38")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGPartyAllDisband()
    {
    }

    [Token(Token = "0x2001722")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005352")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGPartyAllDisband.Response body;

      [Token(Token = "0x6005E39")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
