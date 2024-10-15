// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUnitUsedItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001894")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("Unit/FlowNode_ReqUnitUsedItem", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqUnitUsedItem : FlowNode_Network
  {
    [Token(Token = "0x400583A")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400583B")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x60062F6")]
    [Address(RVA = "0x313010", Offset = "0x311E10", VA = "0x10313010", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062F7")]
    [Address(RVA = "0x3133F0", Offset = "0x3121F0", VA = "0x103133F0")]
    private void Success()
    {
    }

    [Token(Token = "0x60062F8")]
    [Address(RVA = "0x3130F0", Offset = "0x311EF0", VA = "0x103130F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60062F9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqUnitUsedItem()
    {
    }
  }
}
