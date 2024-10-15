// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_InitEnvironment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001407")]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Init", 65535)]
  public class FlowNode_InitEnvironment : FlowNode
  {
    [Token(Token = "0x60053BF")]
    [Address(RVA = "0x1284D10", Offset = "0x1283B10", VA = "0x11284D10")]
    private void Init()
    {
    }

    [Token(Token = "0x60053C0")]
    [Address(RVA = "0x1284FA0", Offset = "0x1283DA0", VA = "0x11284FA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053C1")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_InitEnvironment()
    {
    }
  }
}
