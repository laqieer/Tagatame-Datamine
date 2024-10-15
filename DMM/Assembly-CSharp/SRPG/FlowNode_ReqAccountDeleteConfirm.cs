// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAccountDeleteConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001480")]
  [FlowNode.NodeType("FlowNode_ReqAccountDeleteConfirm", 32741)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqAccountDeleteConfirm : FlowNode_Network
  {
    [Token(Token = "0x4004BC0")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004BC1")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x60055A3")]
    [Address(RVA = "0x12B4F20", Offset = "0x12B3D20", VA = "0x112B4F20", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60055A4")]
    [Address(RVA = "0x12B52E0", Offset = "0x12B40E0", VA = "0x112B52E0")]
    private void Success()
    {
    }

    [Token(Token = "0x60055A5")]
    [Address(RVA = "0x12B50A0", Offset = "0x12B3EA0", VA = "0x112B50A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055A6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAccountDeleteConfirm()
    {
    }
  }
}
