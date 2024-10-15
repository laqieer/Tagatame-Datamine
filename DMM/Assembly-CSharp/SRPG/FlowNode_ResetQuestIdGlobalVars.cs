// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ResetQuestIdGlobalVars
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001817")]
  [FlowNode.NodeType("Story/ResetGlobalVars", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "AutoScrollRest", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_ResetQuestIdGlobalVars : FlowNode
  {
    [Token(Token = "0x40056A8")]
    private const int PIN_IN_INPUT = 1;
    [Token(Token = "0x40056A9")]
    private const int PIN_IN_AUTO_SCROLL = 2;
    [Token(Token = "0x40056AA")]
    private const int PIN_OUT_OUTPUT = 100;

    [Token(Token = "0x6006149")]
    [Address(RVA = "0x136D400", Offset = "0x136C200", VA = "0x1136D400", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600614A")]
    [Address(RVA = "0x136D770", Offset = "0x136C570", VA = "0x1136D770")]
    private void ResetGlobalVars()
    {
    }

    [Token(Token = "0x600614B")]
    [Address(RVA = "0x136D670", Offset = "0x136C470", VA = "0x1136D670")]
    private void ResetAutoScrollGlobalVars()
    {
    }

    [Token(Token = "0x600614C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ResetQuestIdGlobalVars()
    {
    }
  }
}
