// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAdventureParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012E1")]
  [FlowNode.Pin(201, "SallyOfUnit", FlowNode.PinTypes.Output, 201)]
  [FlowNode.NodeType("Adventure/Req/AdventureParty", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqAdventureParty : FlowNode_Network
  {
    [Token(Token = "0x400464D")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400464E")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400464F")]
    protected const int PIN_OUT_SALLY_OF_UNIT = 201;

    [Token(Token = "0x6004FE7")]
    [Address(RVA = "0x12504C0", Offset = "0x124F2C0", VA = "0x112504C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FE8")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6004FE9")]
    [Address(RVA = "0x1250750", Offset = "0x124F550", VA = "0x11250750", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6004FEA")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAdventureParty()
    {
    }

    [Token(Token = "0x20012E2")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004650")]
      [FieldOffset(Offset = "0x28")]
      public ReqAdventureParty.Response body;

      [Token(Token = "0x6004FEB")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
