// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_RankMatchStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200178A")]
  [AddComponentMenu("")]
  [FlowNode.Pin(302, "Maintenance", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(301, "No Match Version", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.NodeType("MultiPlay/API/RankMatch/Status", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_MP_API_RankMatchStatus : FlowNode_Network
  {
    [Token(Token = "0x40054A6")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40054A7")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054A8")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054A9")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x40054AA")]
    private const int PIN_OUT_MAINTENANCE = 302;

    [Token(Token = "0x6005F7A")]
    [Address(RVA = "0x1336B10", Offset = "0x1335910", VA = "0x11336B10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F7B")]
    [Address(RVA = "0x1336BD0", Offset = "0x13359D0", VA = "0x11336BD0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F7C")]
    [Address(RVA = "0x1337090", Offset = "0x1335E90", VA = "0x11337090")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F7D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_RankMatchStatus()
    {
    }
  }
}
