// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_QuestSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200146A")]
  [FlowNode.NodeType("System/Quest/Selector", 32741)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_QuestSelector : FlowNode
  {
    [Token(Token = "0x4004B84")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GlobalVars.EventQuestListType EventQuestListType;

    [Token(Token = "0x600555F")]
    [Address(RVA = "0x129B800", Offset = "0x129A600", VA = "0x1129B800", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005560")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_QuestSelector()
    {
    }
  }
}
