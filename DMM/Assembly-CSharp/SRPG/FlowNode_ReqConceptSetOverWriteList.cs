// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptSetOverWriteList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014E5")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("FlowNode_ReqConceptSetOverWriteList", 32741)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqConceptSetOverWriteList : FlowNode_Network
  {
    [Token(Token = "0x4004C95")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004C96")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4004C97")]
    public const string KEY_CONCEPTSETOVERWRITE_SET_LIST = "KEY_CONCEPTSETOVERWRITE_SET_LIST";
    [Token(Token = "0x4004C98")]
    public const string KEY_CONCEPTSETOVERWRITE_PTYPE = "KEY_CONCEPTSETOVERWRITE_PTYPE";

    [Token(Token = "0x60056EB")]
    [Address(RVA = "0x12C60C0", Offset = "0x12C4EC0", VA = "0x112C60C0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60056EC")]
    [Address(RVA = "0x12C6860", Offset = "0x12C5660", VA = "0x112C6860")]
    private void Success()
    {
    }

    [Token(Token = "0x60056ED")]
    [Address(RVA = "0x12C6540", Offset = "0x12C5340", VA = "0x112C6540", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056EE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptSetOverWriteList()
    {
    }
  }
}
