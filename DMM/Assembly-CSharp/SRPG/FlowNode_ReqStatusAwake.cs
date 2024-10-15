// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqStatusAwake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001896")]
  [FlowNode.NodeType("Unit/Req/StatusAwake", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqStatusAwake : FlowNode_Network
  {
    [Token(Token = "0x400583E")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400583F")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60062FE")]
    [Address(RVA = "0x30C6A0", Offset = "0x30B4A0", VA = "0x1030C6A0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60062FF")]
    [Address(RVA = "0x30CBF0", Offset = "0x30B9F0", VA = "0x1030CBF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006300")]
    [Address(RVA = "0x30C8B0", Offset = "0x30B6B0", VA = "0x1030C8B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006301")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqStatusAwake()
    {
    }
  }
}
