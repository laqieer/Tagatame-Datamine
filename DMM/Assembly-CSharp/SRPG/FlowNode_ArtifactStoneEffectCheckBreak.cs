// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ArtifactStoneEffectCheckBreak
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001368")]
  [FlowNode.Pin(2, "True", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "False", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "判定", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("ArtifactStoneEffectCheckBreak", 32741)]
  public class FlowNode_ArtifactStoneEffectCheckBreak : FlowNode
  {
    [Token(Token = "0x40047A5")]
    private const int PIN_ID_IN = 1;
    [Token(Token = "0x40047A6")]
    private const int PIN_ID_TRUE = 2;
    [Token(Token = "0x40047A7")]
    private const int PIN_ID_FALSE = 3;

    [Token(Token = "0x600516A")]
    [Address(RVA = "0x12668F0", Offset = "0x12656F0", VA = "0x112668F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600516B")]
    [Address(RVA = "0x1266830", Offset = "0x1265630", VA = "0x11266830")]
    public void CheckBreak()
    {
    }

    [Token(Token = "0x600516C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ArtifactStoneEffectCheckBreak()
    {
    }
  }
}
