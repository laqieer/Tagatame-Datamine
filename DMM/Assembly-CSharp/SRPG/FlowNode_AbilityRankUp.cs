// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AbilityRankUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200135F")]
  [FlowNode.NodeType("System/Unit/AbilityRankUp", 32741)]
  [FlowNode.Pin(4, "アビリティポイントが不足", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "アビリティ成長限界に達している", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "アビリティ成長可能回数が不足", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_AbilityRankUp : FlowNode
  {
    [Token(Token = "0x600514F")]
    [Address(RVA = "0x1264BA0", Offset = "0x12639A0", VA = "0x11264BA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005150")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_AbilityRankUp()
    {
    }
  }
}
