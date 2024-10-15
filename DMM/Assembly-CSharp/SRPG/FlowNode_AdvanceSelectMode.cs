// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AdvanceSelectMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012D1")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(3, "Extra", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Elite", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Normal", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Advance/SelectMode", 32741)]
  public class FlowNode_AdvanceSelectMode : FlowNode
  {
    [Token(Token = "0x4004621")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FlowNode_AdvanceSelectMode.ModeTarget mModeTarget;

    [Token(Token = "0x6004FBD")]
    [Address(RVA = "0x1249660", Offset = "0x1248460", VA = "0x11249660", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FBE")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_AdvanceSelectMode()
    {
    }

    [Token(Token = "0x20012D2")]
    public enum ModeTarget
    {
      [Token(Token = "0x4004623")] Stage,
      [Token(Token = "0x4004624")] Boss,
    }
  }
}
