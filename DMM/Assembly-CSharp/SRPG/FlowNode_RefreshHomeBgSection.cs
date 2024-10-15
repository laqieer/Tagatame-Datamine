// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RefreshHomeBgSection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001732")]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("Home/RefreshHomeBgSection", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_RefreshHomeBgSection : FlowNode
  {
    [Token(Token = "0x400537A")]
    private const int PIN_IN_INPUT = 1;
    [Token(Token = "0x400537B")]
    private const int PIN_OUT_OUTPUT = 100;

    [Token(Token = "0x6005E61")]
    [Address(RVA = "0x1319D30", Offset = "0x1318B30", VA = "0x11319D30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E62")]
    [Address(RVA = "0x1319D60", Offset = "0x1318B60", VA = "0x11319D60")]
    private void Refresh_HomeBgSection()
    {
    }

    [Token(Token = "0x6005E63")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RefreshHomeBgSection()
    {
    }
  }
}
