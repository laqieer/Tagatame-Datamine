// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsRuneBoxFull
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200183C")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Rune/IsRuneBoxFull", 32741)]
  [FlowNode.Pin(10, "ルーンのBoxが満タンか？", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "true", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(110, "false", FlowNode.PinTypes.Output, 110)]
  public class FlowNode_IsRuneBoxFull : FlowNode
  {
    [Token(Token = "0x40056EB")]
    private const int PIN_INPUT_CHECK = 10;
    [Token(Token = "0x40056EC")]
    private const int PIN_OUTPUT_TRUE = 100;
    [Token(Token = "0x40056ED")]
    private const int PIN_OUTPUT_FALSE = 110;

    [Token(Token = "0x60061C9")]
    [Address(RVA = "0x1359620", Offset = "0x1358420", VA = "0x11359620", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60061CA")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsRuneBoxFull()
    {
    }
  }
}
