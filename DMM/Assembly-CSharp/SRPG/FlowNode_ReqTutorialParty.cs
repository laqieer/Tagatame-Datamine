// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTutorialParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015C4")]
  [FlowNode.NodeType("Tutorial/StartParty")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_ReqTutorialParty : FlowNode_Network
  {
    [Token(Token = "0x6005988")]
    [Address(RVA = "0x12E2800", Offset = "0x12E1600", VA = "0x112E2800", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005989")]
    [Address(RVA = "0x12E2A50", Offset = "0x12E1850", VA = "0x112E2A50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600598A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTutorialParty()
    {
    }
  }
}
