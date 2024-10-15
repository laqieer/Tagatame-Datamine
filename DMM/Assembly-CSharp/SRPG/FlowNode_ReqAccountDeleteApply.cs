// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAccountDeleteApply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200147F")]
  [FlowNode.NodeType("FlowNode_ReqAccountDeleteApply", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqAccountDeleteApply : FlowNode_Network
  {
    [Token(Token = "0x4004BBE")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004BBF")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x600559E")]
    [Address(RVA = "0x12B4AF0", Offset = "0x12B38F0", VA = "0x112B4AF0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600559F")]
    [Address(RVA = "0x12B4E90", Offset = "0x12B3C90", VA = "0x112B4E90")]
    private void Success()
    {
    }

    [Token(Token = "0x60055A0")]
    [Address(RVA = "0x12B4C50", Offset = "0x12B3A50", VA = "0x112B4C50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055A1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAccountDeleteApply()
    {
    }
  }
}
