// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BuyStamina
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001374")]
  [FlowNode.Pin(3, "スタミナ満タン", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(6, "Close", FlowNode.PinTypes.Output, 6)]
  [FlowNode.NodeType("System/Buy/BuyStamina", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(5, "購入回数制限", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(4, "コインが足りなかった", FlowNode.PinTypes.Output, 4)]
  public class FlowNode_BuyStamina : FlowNode_Network
  {
    [Token(Token = "0x40047D5")]
    [FieldOffset(Offset = "0x0")]
    public static GameObject ConfirmBoxObj;
    [Token(Token = "0x40047D6")]
    [FieldOffset(Offset = "0x20")]
    public bool Confirm;
    [Token(Token = "0x40047D7")]
    [FieldOffset(Offset = "0x21")]
    public bool ShowResult;

    [Token(Token = "0x60051A1")]
    [Address(RVA = "0x126A0A0", Offset = "0x1268EA0", VA = "0x1126A0A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051A2")]
    [Address(RVA = "0x126A4D0", Offset = "0x12692D0", VA = "0x1126A4D0")]
    private void OnClose(GameObject go)
    {
    }

    [Token(Token = "0x60051A3")]
    [Address(RVA = "0x126A920", Offset = "0x1269720", VA = "0x1126A920")]
    private void OutOfCoin()
    {
    }

    [Token(Token = "0x60051A4")]
    [Address(RVA = "0x126AE70", Offset = "0x1269C70", VA = "0x1126AE70")]
    private void StaminaFull()
    {
    }

    [Token(Token = "0x60051A5")]
    [Address(RVA = "0x126A870", Offset = "0x1269670", VA = "0x1126A870")]
    private void OutOfBuyCount()
    {
    }

    [Token(Token = "0x60051A6")]
    [Address(RVA = "0x126A4B0", Offset = "0x12692B0", VA = "0x1126A4B0")]
    private void OnBuy(GameObject go)
    {
    }

    [Token(Token = "0x60051A7")]
    [Address(RVA = "0x126AB10", Offset = "0x1269910", VA = "0x1126AB10")]
    private void SendRequest()
    {
    }

    [Token(Token = "0x60051A8")]
    [Address(RVA = "0x126AF20", Offset = "0x1269D20", VA = "0x1126AF20")]
    private void Success()
    {
    }

    [Token(Token = "0x60051A9")]
    [Address(RVA = "0x126A4F0", Offset = "0x12692F0", VA = "0x1126A4F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60051AA")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_BuyStamina()
    {
    }
  }
}
