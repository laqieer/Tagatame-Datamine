// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAccountDeleteStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001481")]
  [FlowNode.NodeType("FlowNode_ReqAccountDeleteStart", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqAccountDeleteStart : FlowNode_Network
  {
    [Token(Token = "0x4004BC2")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004BC3")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x60055A8")]
    [Address(RVA = "0x12B5350", Offset = "0x12B4150", VA = "0x112B5350", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60055A9")]
    [Address(RVA = "0x12B5880", Offset = "0x12B4680", VA = "0x112B5880")]
    private void Success(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60055AA")]
    [Address(RVA = "0x12B5550", Offset = "0x12B4350", VA = "0x112B5550", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055AB")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAccountDeleteStart()
    {
    }
  }
}
