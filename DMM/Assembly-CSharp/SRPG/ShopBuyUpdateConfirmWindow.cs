// Decompiled with JetBrains decompiler
// Type: SRPG.ShopBuyUpdateConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A94")]
  [AddComponentMenu("UI/ShopBuyUpdateConfirmWindow")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class ShopBuyUpdateConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CF7C")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼タイトル/本文のText")]
    public Text Title;
    [Token(Token = "0x400CF7D")]
    [FieldOffset(Offset = "0x10")]
    public Text Message;
    [Token(Token = "0x400CF7E")]
    [FieldOffset(Offset = "0x14")]
    [HeaderBar("▼はい/いいえボタンText(未設定ならprefab設定)")]
    public Text DecideText;
    [Token(Token = "0x400CF7F")]
    [FieldOffset(Offset = "0x18")]
    public Text CancelText;
    [Token(Token = "0x400CF80")]
    [FieldOffset(Offset = "0x1C")]
    [HeaderBar("▼所持幻晶石情報")]
    public GameObject HaveAmount;
    [Token(Token = "0x400CF81")]
    [FieldOffset(Offset = "0x20")]
    [HeaderBar("▼幻晶石使用確認")]
    public GameObject CoinWarningObj;
    [Token(Token = "0x400CF82")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("▼ショップ更新期限情報")]
    public GameObject LimitTimeParent;
    [Token(Token = "0x400CF83")]
    [FieldOffset(Offset = "0x28")]
    public Text LimitTimeText;

    [Token(Token = "0x600C273")]
    [Address(RVA = "0x8AA8F0", Offset = "0x8A96F0", VA = "0x108AA8F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C274")]
    [Address(RVA = "0x8AA910", Offset = "0x8A9710", VA = "0x108AA910")]
    private void Start()
    {
    }

    [Token(Token = "0x600C275")]
    [Address(RVA = "0x7E3D80", Offset = "0x7E2B80", VA = "0x107E3D80")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C276")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopBuyUpdateConfirmWindow()
    {
    }
  }
}
