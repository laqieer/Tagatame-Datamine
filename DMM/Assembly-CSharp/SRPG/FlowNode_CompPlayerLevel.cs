// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CompPlayerLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001684")]
  [FlowNode.Pin(1, "Comp(指定したレベルに対して)", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(112, "Equal", FlowNode.PinTypes.Output, 112)]
  [FlowNode.NodeType("System/CompPlayerLevel", 32741)]
  [FlowNode.Pin(113, "Lower", FlowNode.PinTypes.Output, 113)]
  [AddComponentMenu("")]
  [FlowNode.Pin(111, "Upper", FlowNode.PinTypes.Output, 111)]
  public class FlowNode_CompPlayerLevel : FlowNode
  {
    [Token(Token = "0x40051DD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int mCompPlayerLevel;
    [Token(Token = "0x40051DE")]
    private const int PIN_IN_COMP = 1;
    [Token(Token = "0x40051DF")]
    private const int PIN_OUT_UPPER = 111;
    [Token(Token = "0x40051E0")]
    private const int PIN_OUT_EQUAL = 112;
    [Token(Token = "0x40051E1")]
    private const int PIN_OUT_LOWER = 113;

    [Token(Token = "0x6005C63")]
    [Address(RVA = "0x1306040", Offset = "0x1304E40", VA = "0x11306040", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C64")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CompPlayerLevel()
    {
    }
  }
}
