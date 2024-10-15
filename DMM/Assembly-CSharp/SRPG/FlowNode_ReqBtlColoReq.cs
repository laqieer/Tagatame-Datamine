// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBtlColoReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014B0")]
  public class FlowNode_ReqBtlColoReq : FlowNode_Network
  {
    [Token(Token = "0x4004C0A")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqBtlColoReq.OnSuccesDelegate mOnSuccessDelegate;

    [Token(Token = "0x1700093A")]
    public FlowNode_ReqBtlColoReq.OnSuccesDelegate OnSuccessListeners
    {
      [Token(Token = "0x6005642"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x6005643")]
    [Address(RVA = "0x12BBEB0", Offset = "0x12BACB0", VA = "0x112BBEB0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005644")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBtlColoReq()
    {
    }

    [Token(Token = "0x20014B1")]
    public delegate void OnSuccesDelegate(BattleCore.Json_Battle response);
  }
}
