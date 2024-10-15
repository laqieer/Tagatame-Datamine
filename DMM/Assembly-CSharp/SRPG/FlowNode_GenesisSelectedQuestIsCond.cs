// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GenesisSelectedQuestIsCond
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001691")]
  [FlowNode.NodeType("Genesis/難易度開放の可能性があるクエストか？", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(21, "難易度開放開放の可能性なし", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(11, "難易度開放の可能性あり", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_GenesisSelectedQuestIsCond : FlowNode
  {
    [Token(Token = "0x4005209")]
    private const int PIN_IN = 1;
    [Token(Token = "0x400520A")]
    private const int PIN_OUT_TRUE = 11;
    [Token(Token = "0x400520B")]
    private const int PIN_OUT_FALSE = 21;

    [Token(Token = "0x6005C97")]
    [Address(RVA = "0x1307DB0", Offset = "0x1306BB0", VA = "0x11307DB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C98")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GenesisSelectedQuestIsCond()
    {
    }
  }
}
