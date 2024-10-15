// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckBuffSetState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001746")]
  [FlowNode.Pin(11, "Buff設定アリ", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("LeagueMatch/CheckBuffState", 32741)]
  [FlowNode.Pin(1, "input", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(12, "Buff設定ナシ", FlowNode.PinTypes.Output, 12)]
  public class FlowNode_CheckBuffSetState : FlowNode
  {
    [Token(Token = "0x40053B6")]
    private const int PIN_IN_INPUT = 1;
    [Token(Token = "0x40053B7")]
    private const int PIN_OUT_BUFF_SET = 11;
    [Token(Token = "0x40053B8")]
    private const int PIN_OUT_BUFF_NONE = 12;

    [Token(Token = "0x6005EA0")]
    [Address(RVA = "0x1330D20", Offset = "0x132FB20", VA = "0x11330D20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005EA1")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckBuffSetState()
    {
    }
  }
}
