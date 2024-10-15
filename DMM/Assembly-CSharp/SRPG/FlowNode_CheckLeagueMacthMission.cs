// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckLeagueMacthMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001747")]
  [FlowNode.Pin(1, "input", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(12, "受け取れる物「ナシ」", FlowNode.PinTypes.Output, 12)]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "受け取れる物「アリ」", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("LeagueMatch/CheckLeagueMacthMission", 32741)]
  public class FlowNode_CheckLeagueMacthMission : FlowNode
  {
    [Token(Token = "0x40053B9")]
    private const int PIN_IN_INPUT = 1;
    [Token(Token = "0x40053BA")]
    private const int PIN_OUT_RECEIVE_MISSON = 11;
    [Token(Token = "0x40053BB")]
    private const int PIN_OUT_NO_RECEIVE_MISSON = 12;

    [Token(Token = "0x6005EA2")]
    [Address(RVA = "0x1330E70", Offset = "0x132FC70", VA = "0x11330E70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005EA3")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckLeagueMacthMission()
    {
    }
  }
}
