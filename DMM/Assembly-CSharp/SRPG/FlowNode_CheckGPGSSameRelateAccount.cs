// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckGPGSSameRelateAccount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200169B")]
  [FlowNode.NodeType("GPGS/CheckSameRelateAccount", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "True", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "False", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_CheckGPGSSameRelateAccount : FlowNode
  {
    [Token(Token = "0x4005227")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005228")]
    private const int PIN_OUT_TRUE = 100;
    [Token(Token = "0x4005229")]
    private const int PIN_OUT_FALSE = 101;

    [Token(Token = "0x6005CAE")]
    [Address(RVA = "0x316270", Offset = "0x315070", VA = "0x10316270", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CAF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckGPGSSameRelateAccount()
    {
    }
  }
}
