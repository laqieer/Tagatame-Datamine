// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckPeriodDrawCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001345")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("DrawCard/CheckPeriod", 32741)]
  [FlowNode.Pin(10, "True", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "False", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_CheckPeriodDrawCard : FlowNode
  {
    [Token(Token = "0x400475E")]
    private const int PIN_IN_CHECK = 1;
    [Token(Token = "0x400475F")]
    private const int PIN_OUT_TRUE = 10;
    [Token(Token = "0x4004760")]
    private const int PIN_OUT_FALSE = 11;

    [Token(Token = "0x600510F")]
    [Address(RVA = "0x124F480", Offset = "0x124E280", VA = "0x1124F480", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005110")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckPeriodDrawCard()
    {
    }
  }
}
