// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBtlComEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014A6")]
  [AddComponentMenu("")]
  public class FlowNode_ReqBtlComEnd : FlowNode_Network
  {
    [Token(Token = "0x4004C06")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqBtlComEnd.OnSuccesDelegate mOnSuccessDelegate;

    [Token(Token = "0x17000937")]
    public FlowNode_ReqBtlComEnd.OnSuccesDelegate OnSuccessListeners
    {
      [Token(Token = "0x600561D"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600561E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600561F")]
    [Address(RVA = "0x12BC1A0", Offset = "0x12BAFA0", VA = "0x112BC1A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005620")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBtlComEnd()
    {
    }

    [Token(Token = "0x20014A7")]
    public delegate void OnSuccesDelegate();
  }
}
