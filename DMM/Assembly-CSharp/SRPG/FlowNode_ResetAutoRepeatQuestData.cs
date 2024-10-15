// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ResetAutoRepeatQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012F8")]
  [FlowNode.NodeType("AutoRepeatQuest/Reset", 32741)]
  [FlowNode.Pin(0, "自動周回データリセット", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Finish", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_ResetAutoRepeatQuestData : FlowNode
  {
    [Token(Token = "0x4004687")]
    private const int PIN_IN_RESET = 0;
    [Token(Token = "0x4004688")]
    private const int PIN_OT_RESET = 10;
    [Token(Token = "0x4004689")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool IsOnlyMeasuringReset;

    [Token(Token = "0x600502F")]
    [Address(RVA = "0x1263900", Offset = "0x1262700", VA = "0x11263900", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005030")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ResetAutoRepeatQuestData()
    {
    }
  }
}
