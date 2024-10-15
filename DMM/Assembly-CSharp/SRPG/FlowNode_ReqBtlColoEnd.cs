// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBtlColoEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014A8")]
  public class FlowNode_ReqBtlColoEnd : FlowNode_Network
  {
    [Token(Token = "0x4004C07")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqBtlColoEnd.OnSuccesDelegate mOnSuccessDelegate;

    [Token(Token = "0x17000938")]
    public FlowNode_ReqBtlColoEnd.OnSuccesDelegate OnSuccessListeners
    {
      [Token(Token = "0x6005625"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x6005626")]
    [Address(RVA = "0x12BBC20", Offset = "0x12BAA20", VA = "0x112BBC20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005627")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBtlColoEnd()
    {
    }

    [Token(Token = "0x20014A9")]
    public delegate void OnSuccesDelegate();
  }
}
