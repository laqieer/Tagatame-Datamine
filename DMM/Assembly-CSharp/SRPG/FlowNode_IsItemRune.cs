// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsItemRune
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200183B")]
  [FlowNode.NodeType("Rune/IsItemRune", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(102, "False", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "True", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "CheckStart", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_IsItemRune : FlowNode
  {
    [Token(Token = "0x40056E7")]
    private const int PIN_INPUT_CHECK_START = 1;
    [Token(Token = "0x40056E8")]
    private const int PIN_OUTPUT_TRUE = 101;
    [Token(Token = "0x40056E9")]
    private const int PIN_OUTPUT_FALSE = 102;
    [Token(Token = "0x40056EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Target;

    [Token(Token = "0x60061C7")]
    [Address(RVA = "0x13594B0", Offset = "0x13582B0", VA = "0x113594B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60061C8")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsItemRune()
    {
    }
  }
}
