// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUnitUsedUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001895")]
  [FlowNode.NodeType("Unit/FlowNode_ReqUnitUsedUnit", 32741)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqUnitUsedUnit : FlowNode_Network
  {
    [Token(Token = "0x400583C")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400583D")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x60062FA")]
    [Address(RVA = "0x313460", Offset = "0x312260", VA = "0x10313460", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062FB")]
    [Address(RVA = "0x313840", Offset = "0x312640", VA = "0x10313840")]
    private void Success()
    {
    }

    [Token(Token = "0x60062FC")]
    [Address(RVA = "0x313540", Offset = "0x312340", VA = "0x10313540", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60062FD")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqUnitUsedUnit()
    {
    }
  }
}
