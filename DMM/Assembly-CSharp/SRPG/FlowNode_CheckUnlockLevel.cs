// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckUnlockLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001390")]
  [FlowNode.NodeType("SRPG/CheckUnlockLevel", 32741)]
  [FlowNode.Pin(101, "Check", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(1001, "True", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1002, "False", FlowNode.PinTypes.Output, 1002)]
  [AddComponentMenu("")]
  public class FlowNode_CheckUnlockLevel : FlowNode
  {
    [Token(Token = "0x400484D")]
    private const int PIN_INPUT_START_CHECK = 101;
    [Token(Token = "0x400484E")]
    private const int PIN_OUTPUT_TRUE = 1001;
    [Token(Token = "0x400484F")]
    private const int PIN_OUTPUT_FALSE = 1002;
    [Token(Token = "0x4004850")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public long Condition;

    [Token(Token = "0x170008FC")]
    private UnlockTargets condition
    {
      [Token(Token = "0x6005204"), Address(RVA = "0x34F480", Offset = "0x34E280", VA = "0x1034F480")] get
      {
        return new UnlockTargets();
      }
      [Token(Token = "0x6005205"), Address(RVA = "0x372E10", Offset = "0x371C10", VA = "0x10372E10")] set
      {
      }
    }

    [Token(Token = "0x6005206")]
    [Address(RVA = "0x126DEA0", Offset = "0x126CCA0", VA = "0x1126DEA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005207")]
    [Address(RVA = "0x126DDD0", Offset = "0x126CBD0", VA = "0x1126DDD0")]
    private void Check()
    {
    }

    [Token(Token = "0x6005208")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckUnlockLevel()
    {
    }
  }
}
