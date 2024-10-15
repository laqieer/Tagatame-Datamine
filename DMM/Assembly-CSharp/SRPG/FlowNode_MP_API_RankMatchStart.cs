// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_RankMatchStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001789")]
  [FlowNode.NodeType("MultiPlay/API/RankMatch/Start", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(301, "No Match Version", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(302, "Maintenance", FlowNode.PinTypes.Output, 302)]
  [AddComponentMenu("")]
  public class FlowNode_MP_API_RankMatchStart : FlowNode_Network
  {
    [Token(Token = "0x40054A1")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40054A2")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054A3")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054A4")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x40054A5")]
    private const int PIN_OUT_MAINTENANCE = 302;

    [Token(Token = "0x6005F75")]
    [Address(RVA = "0x1336400", Offset = "0x1335200", VA = "0x11336400", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F76")]
    [Address(RVA = "0x13364C0", Offset = "0x13352C0", VA = "0x113364C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F77")]
    [Address(RVA = "0x1336AA0", Offset = "0x13358A0", VA = "0x11336AA0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F78")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_RankMatchStart()
    {
    }
  }
}
