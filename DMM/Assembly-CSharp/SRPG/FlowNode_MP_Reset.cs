// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_Reset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017C9")]
  [FlowNode.NodeType("MultiPlay/Photon/Reset", 32741)]
  [FlowNode.Pin(1, "Reset", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Done", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_MP_Reset : FlowNode
  {
    [Token(Token = "0x400558B")]
    private const int PIN_IN_RESET = 1;
    [Token(Token = "0x400558C")]
    private const int PIN_OUT_DONE = 11;

    [Token(Token = "0x600605D")]
    [Address(RVA = "0x1350F50", Offset = "0x134FD50", VA = "0x11350F50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600605E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_Reset()
    {
    }
  }
}
