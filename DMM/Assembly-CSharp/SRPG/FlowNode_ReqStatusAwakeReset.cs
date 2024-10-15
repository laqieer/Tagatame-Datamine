// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqStatusAwakeReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001898")]
  [FlowNode.NodeType("Unit/Req/StatusAwakeReset", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqStatusAwakeReset : FlowNode_Network
  {
    [Token(Token = "0x4005842")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005843")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6006306")]
    [Address(RVA = "0x30C160", Offset = "0x30AF60", VA = "0x1030C160", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6006307")]
    [Address(RVA = "0x30C630", Offset = "0x30B430", VA = "0x1030C630")]
    private void Success()
    {
    }

    [Token(Token = "0x6006308")]
    [Address(RVA = "0x30C300", Offset = "0x30B100", VA = "0x1030C300", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006309")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqStatusAwakeReset()
    {
    }
  }
}
