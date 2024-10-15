// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PaymentCheckChargeLimit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200144D")]
  [FlowNode.Pin(205, "VipRemains", FlowNode.PinTypes.Output, 205)]
  [FlowNode.Pin(206, "PremiumRemains", FlowNode.PinTypes.Output, 206)]
  [FlowNode.Pin(204, "LimitOver", FlowNode.PinTypes.Output, 204)]
  [FlowNode.Pin(209, "CanNotBuyUnlockLv", FlowNode.PinTypes.Output, 209)]
  [FlowNode.Pin(208, "ExpansionTermRemains", FlowNode.PinTypes.Output, 208)]
  [FlowNode.Pin(203, "NeedBirthday", FlowNode.PinTypes.Output, 203)]
  [FlowNode.Pin(207, "PremiumInvaid", FlowNode.PinTypes.Output, 207)]
  [FlowNode.Pin(201, "NonAge", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(200, "Error", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(202, "NeedCheck", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Payment/CheckChargeLimit", 32741)]
  public class FlowNode_PaymentCheckChargeLimit : FlowNode_Network
  {
    [Token(Token = "0x4004B15")]
    [FieldOffset(Offset = "0x20")]
    private bool mSetDelegate;

    [Token(Token = "0x60054D0")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void RemoveDelegate()
    {
    }

    [Token(Token = "0x60054D1")]
    [Address(RVA = "0xB056E0", Offset = "0xB044E0", VA = "0x10B056E0", Slot = "1")]
    ~FlowNode_PaymentCheckChargeLimit()
    {
    }

    [Token(Token = "0x60054D2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x60054D3")]
    [Address(RVA = "0x1293B90", Offset = "0x1292990", VA = "0x11293B90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054D4")]
    [Address(RVA = "0x1294520", Offset = "0x1293320", VA = "0x11294520")]
    private void Success()
    {
    }

    [Token(Token = "0x60054D5")]
    [Address(RVA = "0x1293A00", Offset = "0x1292800", VA = "0x11293A00")]
    private void Failure()
    {
    }

    [Token(Token = "0x60054D6")]
    [Address(RVA = "0x1293B40", Offset = "0x1292940", VA = "0x11293B40")]
    private void NonAge()
    {
    }

    [Token(Token = "0x60054D7")]
    [Address(RVA = "0x1293AF0", Offset = "0x12928F0", VA = "0x11293AF0")]
    private void NeedCheck()
    {
    }

    [Token(Token = "0x60054D8")]
    [Address(RVA = "0x1293AA0", Offset = "0x12928A0", VA = "0x11293AA0")]
    private void NeedBirthday()
    {
    }

    [Token(Token = "0x60054D9")]
    [Address(RVA = "0x1293A50", Offset = "0x1292850", VA = "0x11293A50")]
    private void LimitOver()
    {
    }

    [Token(Token = "0x60054DA")]
    [Address(RVA = "0x1294570", Offset = "0x1293370", VA = "0x11294570")]
    private void VipRemains()
    {
    }

    [Token(Token = "0x60054DB")]
    [Address(RVA = "0x12944D0", Offset = "0x12932D0", VA = "0x112944D0")]
    private void PremiumRemains()
    {
    }

    [Token(Token = "0x60054DC")]
    [Address(RVA = "0x1294480", Offset = "0x1293280", VA = "0x11294480")]
    private void PremiumInvalid()
    {
    }

    [Token(Token = "0x60054DD")]
    [Address(RVA = "0x12939B0", Offset = "0x12927B0", VA = "0x112939B0")]
    private void ExpansionTermRemains()
    {
    }

    [Token(Token = "0x60054DE")]
    [Address(RVA = "0x1293960", Offset = "0x1292760", VA = "0x11293960")]
    private void CanNotBuyUnlockLv()
    {
    }

    [Token(Token = "0x60054DF")]
    [Address(RVA = "0x1293D30", Offset = "0x1292B30", VA = "0x11293D30")]
    public void OnCheckChargeLimit(PaymentManager.ECheckChargeLimitResult result)
    {
    }

    [Token(Token = "0x60054E0")]
    [Address(RVA = "0x1293DE0", Offset = "0x1292BE0", VA = "0x11293DE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60054E1")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PaymentCheckChargeLimit()
    {
    }
  }
}
