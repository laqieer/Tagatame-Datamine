// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckGPGSRelateAccount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200169A")]
  [FlowNode.NodeType("GPGS/CheckRelateAccount", 32741)]
  [FlowNode.Pin(101, "False", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "True", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(102, "Invalid", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_CheckGPGSRelateAccount : FlowNode
  {
    [Token(Token = "0x4005223")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005224")]
    private const int PIN_OUT_TRUE = 100;
    [Token(Token = "0x4005225")]
    private const int PIN_OUT_FALSE = 101;
    [Token(Token = "0x4005226")]
    private const int PIN_OUT_INVALID = 102;

    [Token(Token = "0x6005CAC")]
    [Address(RVA = "0x316270", Offset = "0x315070", VA = "0x10316270", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CAD")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckGPGSRelateAccount()
    {
    }
  }
}
