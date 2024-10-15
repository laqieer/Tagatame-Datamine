// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsExpansionRepurchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200135B")]
  [FlowNode.Pin(101, "可能", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("ExpansionPurchase/IsExpansionRepurchase", 32741)]
  [FlowNode.Pin(102, "不可", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(1, "再購入可能か", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_IsExpansionRepurchase : FlowNode
  {
    [Token(Token = "0x4004794")]
    private const int PIN_IN_REPURCHASE = 1;
    [Token(Token = "0x4004795")]
    private const int PIN_OUT_TRUE = 101;
    [Token(Token = "0x4004796")]
    private const int PIN_OUT_FALSE = 102;

    [Token(Token = "0x6005143")]
    [Address(RVA = "0x1275680", Offset = "0x1274480", VA = "0x11275680", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005144")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsExpansionRepurchase()
    {
    }
  }
}
