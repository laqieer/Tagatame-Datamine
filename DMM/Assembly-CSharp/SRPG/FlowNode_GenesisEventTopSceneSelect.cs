// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GenesisEventTopSceneSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200168B")]
  [FlowNode.Pin(11, "Top", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  [FlowNode.Pin(22, "Boss", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(21, "Stage", FlowNode.PinTypes.Output, 21)]
  [FlowNode.NodeType("Genesis/EventTopSceneSelect", 32741)]
  [FlowNode.Pin(1, "Select", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_GenesisEventTopSceneSelect : FlowNode
  {
    [Token(Token = "0x40051F3")]
    private const int PIN_IN = 1;
    [Token(Token = "0x40051F4")]
    private const int PIN_OUT_TOP = 11;
    [Token(Token = "0x40051F5")]
    private const int PIN_OUT_STAGE = 21;
    [Token(Token = "0x40051F6")]
    private const int PIN_OUT_BOSS = 22;

    [Token(Token = "0x6005C79")]
    [Address(RVA = "0x1307190", Offset = "0x1305F90", VA = "0x11307190", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C7A")]
    [Address(RVA = "0x1307340", Offset = "0x1306140", VA = "0x11307340")]
    private void ToQuest(QuestParam quest, bool is_restore)
    {
    }

    [Token(Token = "0x6005C7B")]
    [Address(RVA = "0x1248FA0", Offset = "0x1247DA0", VA = "0x11248FA0")]
    private void ToTop()
    {
    }

    [Token(Token = "0x6005C7C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GenesisEventTopSceneSelect()
    {
    }
  }
}
