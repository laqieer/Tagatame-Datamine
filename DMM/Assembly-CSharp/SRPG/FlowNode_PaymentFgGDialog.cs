// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PaymentFgGDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001450")]
  [FlowNode.Pin(10, "処理なし", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  [FlowNode.Pin(3, "FgG連携を開く", FlowNode.PinTypes.Output, 3)]
  [FlowNode.NodeType("Payment/FgGDialog", 32741)]
  [FlowNode.Pin(1, "OpenYesNo", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Cancel", FlowNode.PinTypes.Output, 2)]
  public class FlowNode_PaymentFgGDialog : FlowNode
  {
    [Token(Token = "0x4004B2A")]
    private const int PIN_IN_OPEN_DIALOG = 1;
    [Token(Token = "0x4004B2B")]
    private const int PIN_OUT_CANCEL = 2;
    [Token(Token = "0x4004B2C")]
    private const int PIN_OUT_OPEN_FGG = 3;
    [Token(Token = "0x4004B2D")]
    private const int PIN_OUT_NOTING = 10;
    [Token(Token = "0x4004B2E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string mSysTitle;
    [Token(Token = "0x4004B2F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private string mSysText;
    [Token(Token = "0x4004B30")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string mSysAuthButton;
    [Token(Token = "0x4004B31")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private string mSysCancelButton;
    [Token(Token = "0x4004B32")]
    [FieldOffset(Offset = "0x28")]
    private GameObject winGO;

    [Token(Token = "0x60054F1")]
    [Address(RVA = "0x1295E90", Offset = "0x1294C90", VA = "0x11295E90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054F2")]
    [Address(RVA = "0x1295DF0", Offset = "0x1294BF0", VA = "0x11295DF0")]
    private void GenerateProductMessage(
      ref string title,
      ref string text,
      ref string auth,
      ref string cancel)
    {
    }

    [Token(Token = "0x60054F3")]
    [Address(RVA = "0x1296080", Offset = "0x1294E80", VA = "0x11296080")]
    private void OpenDialog()
    {
    }

    [Token(Token = "0x60054F4")]
    [Address(RVA = "0x1296000", Offset = "0x1294E00", VA = "0x11296000")]
    private void OnClickOK(GameObject go)
    {
    }

    [Token(Token = "0x60054F5")]
    [Address(RVA = "0x1295F80", Offset = "0x1294D80", VA = "0x11295F80")]
    private void OnClickCancel(GameObject go)
    {
    }

    [Token(Token = "0x60054F6")]
    [Address(RVA = "0x1296270", Offset = "0x1295070", VA = "0x11296270")]
    public FlowNode_PaymentFgGDialog()
    {
    }
  }
}
