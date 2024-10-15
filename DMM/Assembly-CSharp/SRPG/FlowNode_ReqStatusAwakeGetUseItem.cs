// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqStatusAwakeGetUseItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001897")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Unit/Req/StatusAwakeGetUseItem", 32741)]
  public class FlowNode_ReqStatusAwakeGetUseItem : FlowNode_Network
  {
    [Token(Token = "0x4005840")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005841")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6006302")]
    [Address(RVA = "0x30BC00", Offset = "0x30AA00", VA = "0x1030BC00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006303")]
    [Address(RVA = "0x30C0F0", Offset = "0x30AEF0", VA = "0x1030C0F0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006304")]
    [Address(RVA = "0x30BE10", Offset = "0x30AC10", VA = "0x1030BE10", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006305")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqStatusAwakeGetUseItem()
    {
    }
  }
}
