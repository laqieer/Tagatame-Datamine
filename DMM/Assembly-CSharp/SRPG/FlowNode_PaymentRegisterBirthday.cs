// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PaymentRegisterBirthday
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001454")]
  [AddComponentMenu("")]
  [FlowNode.Pin(200, "Error", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Payment/RegisterBirthday", 32741)]
  public class FlowNode_PaymentRegisterBirthday : FlowNode
  {
    [Token(Token = "0x4004B36")]
    [FieldOffset(Offset = "0x18")]
    private bool mSetDelegate;

    [Token(Token = "0x6005508")]
    [Address(RVA = "0x1297200", Offset = "0x1296000", VA = "0x11297200")]
    private void RemoveDelegate()
    {
    }

    [Token(Token = "0x6005509")]
    [Address(RVA = "0x1296F60", Offset = "0x1295D60", VA = "0x11296F60", Slot = "1")]
    ~FlowNode_PaymentRegisterBirthday()
    {
    }

    [Token(Token = "0x600550A")]
    [Address(RVA = "0x1297170", Offset = "0x1295F70", VA = "0x11297170", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600550B")]
    [Address(RVA = "0x1297000", Offset = "0x1295E00", VA = "0x11297000", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600550C")]
    [Address(RVA = "0x12972F0", Offset = "0x12960F0", VA = "0x112972F0")]
    private void Success()
    {
    }

    [Token(Token = "0x600550D")]
    [Address(RVA = "0x1296F00", Offset = "0x1295D00", VA = "0x11296F00")]
    private void Failure()
    {
    }

    [Token(Token = "0x600550E")]
    [Address(RVA = "0x1297190", Offset = "0x1295F90", VA = "0x11297190")]
    public void OnRegisterBirthday(PaymentManager.ERegisterBirthdayResult result)
    {
    }

    [Token(Token = "0x600550F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PaymentRegisterBirthday()
    {
    }
  }
}
