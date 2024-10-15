// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetRankMatchAttackble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001621")]
  [FlowNode.NodeType("Versus/SetRankMatchAttackble", 32741)]
  [FlowNode.Pin(1, "False", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "End", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "True", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_SetRankMatchAttackble : FlowNode
  {
    [Token(Token = "0x4005033")]
    public const int PIN_INPUT_TRUE = 0;
    [Token(Token = "0x4005034")]
    public const int PIN_INPUT_FALSE = 1;
    [Token(Token = "0x4005035")]
    public const int PIN_OUTPUT_END = 10;

    [Token(Token = "0x6005B01")]
    [Address(RVA = "0x12FBA70", Offset = "0x12FA870", VA = "0x112FBA70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B02")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetRankMatchAttackble()
    {
    }
  }
}
