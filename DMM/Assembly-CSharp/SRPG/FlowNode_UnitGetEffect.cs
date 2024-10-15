// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_UnitGetEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001661")]
  [FlowNode.Pin(10, "終了", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("UI/UnitGetEffect", 32741)]
  [FlowNode.Pin(1, "開始", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_UnitGetEffect : FlowNode
  {
    [Token(Token = "0x4005154")]
    [FieldOffset(Offset = "0x18")]
    private UnitGetWindowController mWindow;

    [Token(Token = "0x6005BF3")]
    [Address(RVA = "0x1314060", Offset = "0x1312E60", VA = "0x11314060", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BF4")]
    [Address(RVA = "0x1314140", Offset = "0x1312F40", VA = "0x11314140")]
    private IEnumerator ShowEffect() => (IEnumerator) null;

    [Token(Token = "0x6005BF5")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_UnitGetEffect()
    {
    }
  }
}
