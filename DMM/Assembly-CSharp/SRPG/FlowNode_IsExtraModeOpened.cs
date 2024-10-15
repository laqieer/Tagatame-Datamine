// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsExtraModeOpened
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200140D")]
  [FlowNode.Pin(0, "StoryExtraがOpenしたか？", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Quest/IsExtraModeOpened", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(110, "No", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(100, "Yes", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_IsExtraModeOpened : FlowNode
  {
    [Token(Token = "0x60053D4")]
    [Address(RVA = "0x1285D80", Offset = "0x1284B80", VA = "0x11285D80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053D5")]
    [Address(RVA = "0x1285B20", Offset = "0x1284920", VA = "0x11285B20")]
    private bool IsOpened() => new bool();

    [Token(Token = "0x60053D6")]
    [Address(RVA = "0x1285A40", Offset = "0x1284840", VA = "0x11285A40")]
    private bool IsCond(QuestParam target_quest, QuestParam cond_quest) => new bool();

    [Token(Token = "0x60053D7")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsExtraModeOpened()
    {
    }
  }
}
