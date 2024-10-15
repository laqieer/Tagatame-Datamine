// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PaymentRequestPurchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001455")]
  [AddComponentMenu("")]
  [FlowNode.Pin(301, "ConnectingDialogClose", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(300, "ConnectingDialogOpen", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(208, "PendingExists", FlowNode.PinTypes.Output, 208)]
  [FlowNode.Pin(207, "Pending", FlowNode.PinTypes.Output, 207)]
  [FlowNode.Pin(206, "NeedBirthday", FlowNode.PinTypes.Output, 206)]
  [FlowNode.Pin(205, "OverLimited", FlowNode.PinTypes.Output, 205)]
  [FlowNode.Pin(200, "Error", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(203, "Cancel", FlowNode.PinTypes.Output, 203)]
  [FlowNode.Pin(202, "Deferred", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(201, "AlreadyOwn", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Payment/RequestPurchase", 32741)]
  [FlowNode.Pin(204, "InsufficientBalances", FlowNode.PinTypes.Output, 204)]
  public class FlowNode_PaymentRequestPurchase : FlowNode
  {
    [Token(Token = "0x4004B37")]
    [FieldOffset(Offset = "0x18")]
    private bool mSetDelegate;

    [Token(Token = "0x6005510")]
    [Address(RVA = "0x1298460", Offset = "0x1297260", VA = "0x11298460")]
    private void RemoveDelegate()
    {
    }

    [Token(Token = "0x6005511")]
    [Address(RVA = "0x1297670", Offset = "0x1296470", VA = "0x11297670", Slot = "1")]
    ~FlowNode_PaymentRequestPurchase()
    {
    }

    [Token(Token = "0x6005512")]
    [Address(RVA = "0x1297AC0", Offset = "0x12968C0", VA = "0x11297AC0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6005513")]
    [Address(RVA = "0x1297890", Offset = "0x1296690", VA = "0x11297890", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005514")]
    [Address(RVA = "0x1298600", Offset = "0x1297400", VA = "0x11298600")]
    private void Success()
    {
    }

    [Token(Token = "0x6005515")]
    [Address(RVA = "0x12975B0", Offset = "0x12963B0", VA = "0x112975B0")]
    private void Error()
    {
    }

    [Token(Token = "0x6005516")]
    [Address(RVA = "0x1297350", Offset = "0x1296150", VA = "0x11297350")]
    private void AlreadyOwn()
    {
    }

    [Token(Token = "0x6005517")]
    [Address(RVA = "0x12974F0", Offset = "0x12962F0", VA = "0x112974F0")]
    private void Deferred()
    {
    }

    [Token(Token = "0x6005518")]
    [Address(RVA = "0x1297410", Offset = "0x1296210", VA = "0x11297410")]
    private void Cancel()
    {
    }

    [Token(Token = "0x6005519")]
    [Address(RVA = "0x1297710", Offset = "0x1296510", VA = "0x11297710")]
    private void InsufficientBalances()
    {
    }

    [Token(Token = "0x600551A")]
    [Address(RVA = "0x1298220", Offset = "0x1297020", VA = "0x11298220")]
    private void OverLimited()
    {
    }

    [Token(Token = "0x600551B")]
    [Address(RVA = "0x12977D0", Offset = "0x12965D0", VA = "0x112977D0")]
    private void NeedBirthday()
    {
    }

    [Token(Token = "0x600551C")]
    [Address(RVA = "0x12983A0", Offset = "0x12971A0", VA = "0x112983A0")]
    private void Pending()
    {
    }

    [Token(Token = "0x600551D")]
    [Address(RVA = "0x12982E0", Offset = "0x12970E0", VA = "0x112982E0")]
    private void PendingExists()
    {
    }

    [Token(Token = "0x600551E")]
    [Address(RVA = "0x1297B00", Offset = "0x1296900", VA = "0x11297B00")]
    public void OnRequestPurchase(
      PaymentManager.ERequestPurchaseResult result,
      PaymentManager.CoinRecord record = null)
    {
    }

    [Token(Token = "0x600551F")]
    [Address(RVA = "0x1297AE0", Offset = "0x12968E0", VA = "0x11297AE0")]
    public void OnRequestProcessing()
    {
    }

    [Token(Token = "0x6005520")]
    [Address(RVA = "0x12974D0", Offset = "0x12962D0", VA = "0x112974D0")]
    public void CloseProcessingDialog()
    {
    }

    [Token(Token = "0x6005521")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PaymentRequestPurchase()
    {
    }
  }
}
