// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PaymentDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200144E")]
  [AddComponentMenu("")]
  [FlowNode.Pin(21, "CloseExpr", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(20, "OpenExpr", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(11, "CloseDetail", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(2, "Yes", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "No", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(1, "OpenYesNo", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Payment/Dialog", 32741)]
  [FlowNode.Pin(10, "OpenDetail", FlowNode.PinTypes.Input, 10)]
  public class FlowNode_PaymentDialog : FlowNode
  {
    [Token(Token = "0x4004B16")]
    private const int PIN_IN_YESNO_DIALOG = 1;
    [Token(Token = "0x4004B17")]
    private const int PIN_OUT_YES = 2;
    [Token(Token = "0x4004B18")]
    private const int PIN_OUT_NO = 3;
    [Token(Token = "0x4004B19")]
    private const int PIN_IN_DETAIL_DIALOG = 10;
    [Token(Token = "0x4004B1A")]
    private const int PIN_OUT_DETAIL_CLOSE = 11;
    [Token(Token = "0x4004B1B")]
    private const int PIN_IN_EXPR_DIALOG = 20;
    [Token(Token = "0x4004B1C")]
    private const int PIN_OUT_EXPR_CLOSE = 21;
    [Token(Token = "0x4004B1D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string CoinShopTitle;
    [Token(Token = "0x4004B1E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private string CoinShopText;
    [Token(Token = "0x4004B1F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string ExpansionShopTitle;
    [Token(Token = "0x4004B20")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private string ExpansionShopText;
    [Token(Token = "0x4004B21")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string FgGShopTitle;
    [Token(Token = "0x4004B22")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private string FgGShopText;
    [Token(Token = "0x4004B23")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private bool richTag;
    [Token(Token = "0x4004B24")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private FlowNode_PaymentDialog.PeriodType mPeriodType;
    [Token(Token = "0x4004B25")]
    [FieldOffset(Offset = "0x38")]
    private GameObject winGO;

    [Token(Token = "0x60054E2")]
    [Address(RVA = "0x1295570", Offset = "0x1294370", VA = "0x11295570", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054E3")]
    [Address(RVA = "0x1295480", Offset = "0x1294280", VA = "0x11295480")]
    private bool IsExpansionConfirm() => new bool();

    [Token(Token = "0x60054E4")]
    [Address(RVA = "0x1294EF0", Offset = "0x1293CF0", VA = "0x11294EF0")]
    private void GenerateProductMessage(ref string title, ref string text)
    {
    }

    [Token(Token = "0x60054E5")]
    [Address(RVA = "0x1294D60", Offset = "0x1293B60", VA = "0x11294D60")]
    private void GenerateExprMessage(ref string title, ref string text)
    {
    }

    [Token(Token = "0x60054E6")]
    [Address(RVA = "0x1295160", Offset = "0x1293F60", VA = "0x11295160")]
    private string GetPeriodText() => (string) null;

    [Token(Token = "0x60054E7")]
    [Address(RVA = "0x1294790", Offset = "0x1293590", VA = "0x11294790")]
    private void GenerateExpantionPurchaseText(ref string main, ref string price)
    {
    }

    [Token(Token = "0x60054E8")]
    [Address(RVA = "0x1295A90", Offset = "0x1294890", VA = "0x11295A90")]
    private void OpenYesNoDialog()
    {
    }

    [Token(Token = "0x60054E9")]
    [Address(RVA = "0x1295870", Offset = "0x1294670", VA = "0x11295870")]
    private void OnClickOK(GameObject go)
    {
    }

    [Token(Token = "0x60054EA")]
    [Address(RVA = "0x12956F0", Offset = "0x12944F0", VA = "0x112956F0")]
    private void OnClickCancel(GameObject go)
    {
    }

    [Token(Token = "0x60054EB")]
    [Address(RVA = "0x12958F0", Offset = "0x12946F0", VA = "0x112958F0")]
    private void OpenDetailDialog()
    {
    }

    [Token(Token = "0x60054EC")]
    [Address(RVA = "0x1295770", Offset = "0x1294570", VA = "0x11295770")]
    private void OnClickDetailOK(GameObject go)
    {
    }

    [Token(Token = "0x60054ED")]
    [Address(RVA = "0x12959B0", Offset = "0x12947B0", VA = "0x112959B0")]
    private void OpenExprDialog()
    {
    }

    [Token(Token = "0x60054EE")]
    [Address(RVA = "0x12957F0", Offset = "0x12945F0", VA = "0x112957F0")]
    private void OnClickExprOK(GameObject go)
    {
    }

    [Token(Token = "0x60054EF")]
    [Address(RVA = "0x12945C0", Offset = "0x12933C0", VA = "0x112945C0")]
    private GameObject ConfirmBox(
      string title,
      string main,
      UIUtility.DialogResultEvent okEventListener,
      UIUtility.DialogResultEvent cancelEventListener,
      GameObject parent = null,
      bool systemModal = false,
      int systemModalPriority = -1,
      string yesText = null,
      string noText = null,
      string periodText = null,
      string price = "")
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60054F0")]
    [Address(RVA = "0x1295DD0", Offset = "0x1294BD0", VA = "0x11295DD0")]
    public FlowNode_PaymentDialog()
    {
    }

    [Token(Token = "0x200144F")]
    private enum PeriodType
    {
      [Token(Token = "0x4004B27")] NONE,
      [Token(Token = "0x4004B28")] END,
      [Token(Token = "0x4004B29")] START_END,
    }
  }
}
