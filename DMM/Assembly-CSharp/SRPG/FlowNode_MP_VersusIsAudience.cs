// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_VersusIsAudience
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017EE")]
  [AddComponentMenu("")]
  [FlowNode.Pin(201, "Yes", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(1, "Is Audience", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/Versus/IsAudience", 32741)]
  [FlowNode.Pin(202, "No", FlowNode.PinTypes.Output, 202)]
  public class FlowNode_MP_VersusIsAudience : FlowNode
  {
    [Token(Token = "0x400562A")]
    private const int PIN_IN_IS_AUDIENCE = 1;
    [Token(Token = "0x400562B")]
    private const int PIN_OUT_YES = 201;
    [Token(Token = "0x400562C")]
    private const int PIN_OUT_NO = 202;

    [Token(Token = "0x60060DA")]
    [Address(RVA = "0x135A8A0", Offset = "0x13596A0", VA = "0x1135A8A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060DB")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_VersusIsAudience()
    {
    }
  }
}
