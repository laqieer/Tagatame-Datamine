// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTutorialSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200188E")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("FlowNode_ReqTutorialSkip", 32741)]
  public class FlowNode_ReqTutorialSkip : FlowNode_Network
  {
    [Token(Token = "0x4005817")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005818")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x60062E0")]
    [Address(RVA = "0x3112B0", Offset = "0x3100B0", VA = "0x103112B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062E1")]
    [Address(RVA = "0x311A90", Offset = "0x310890", VA = "0x10311A90")]
    private void Success()
    {
    }

    [Token(Token = "0x60062E2")]
    [Address(RVA = "0x311640", Offset = "0x310440", VA = "0x10311640", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60062E3")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTutorialSkip()
    {
    }
  }
}
