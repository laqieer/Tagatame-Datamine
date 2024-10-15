// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GenesisSelectMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001694")]
  [FlowNode.NodeType("Genesis/SelectMode", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(3, "Extra", FlowNode.PinTypes.Input, 3)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "Eliete", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Normal", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_GenesisSelectMode : FlowNode
  {
    [Token(Token = "0x4005211")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FlowNode_GenesisSelectMode.ModeTarget mModeTarget;

    [Token(Token = "0x6005C9E")]
    [Address(RVA = "0x1307BD0", Offset = "0x13069D0", VA = "0x11307BD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C9F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GenesisSelectMode()
    {
    }

    [Token(Token = "0x2001695")]
    public enum ModeTarget
    {
      [Token(Token = "0x4005213")] Stage,
      [Token(Token = "0x4005214")] Boss,
    }
  }
}
