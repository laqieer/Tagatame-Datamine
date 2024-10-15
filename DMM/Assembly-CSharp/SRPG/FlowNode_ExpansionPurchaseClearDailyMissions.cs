// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ExpansionPurchaseClearDailyMissions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001359")]
  [FlowNode.NodeType("ExpansionPurchase/ExpansionPurchaseClearDailyMissions", 32741)]
  [FlowNode.Pin(10, "output", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ExpansionPurchaseClearDailyMissions : FlowNode
  {
    [Token(Token = "0x4004791")]
    private const int PIN_IN_INPUT = 1;
    [Token(Token = "0x4004792")]
    private const int PIN_OUT_OUTPUT = 10;

    [Token(Token = "0x600513F")]
    [Address(RVA = "0x1275390", Offset = "0x1274190", VA = "0x11275390", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005140")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ExpansionPurchaseClearDailyMissions()
    {
    }
  }
}
