// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBtlComReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014AE")]
  [AddComponentMenu("")]
  public class FlowNode_ReqBtlComReq : FlowNode_Network
  {
    [Token(Token = "0x4004C09")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqBtlComReq.OnSuccesDelegate mOnSuccessDelegate;

    [Token(Token = "0x17000939")]
    public FlowNode_ReqBtlComReq.OnSuccesDelegate OnSuccessListeners
    {
      [Token(Token = "0x600563A"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600563B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600563C")]
    [Address(RVA = "0x12BCE20", Offset = "0x12BBC20", VA = "0x112BCE20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600563D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBtlComReq()
    {
    }

    [Token(Token = "0x20014AF")]
    public delegate void OnSuccesDelegate(BattleCore.Json_Battle response);
  }
}
