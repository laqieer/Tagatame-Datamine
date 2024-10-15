// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBtlComResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014B2")]
  [AddComponentMenu("")]
  public class FlowNode_ReqBtlComResume : FlowNode_Network
  {
    [Token(Token = "0x4004C0B")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqBtlComResume.OnSuccesDelegate mOnSuccessDelegate;

    [Token(Token = "0x1700093B")]
    public FlowNode_ReqBtlComResume.OnSuccesDelegate OnSuccessListeners
    {
      [Token(Token = "0x6005649"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600564A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600564B")]
    [Address(RVA = "0x12BCFB0", Offset = "0x12BBDB0", VA = "0x112BCFB0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600564C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBtlComResume()
    {
    }

    [Token(Token = "0x20014B3")]
    public delegate void OnSuccesDelegate(BattleCore.Json_Battle response);
  }
}
