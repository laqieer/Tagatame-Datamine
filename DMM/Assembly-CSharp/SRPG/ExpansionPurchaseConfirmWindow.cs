// Decompiled with JetBrains decompiler
// Type: SRPG.ExpansionPurchaseConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002862")]
  public class ExpansionPurchaseConfirmWindow : UIDraft
  {
    [Token(Token = "0x400C0D1")]
    public const string PREFAB_PATH = "UI/ExpansionPurchaseConfirmWindow";
    [Token(Token = "0x400C0D2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList[] _ExhibitLists;
    [Token(Token = "0x400C0D3")]
    [FieldOffset(Offset = "0x10")]
    private ExpansionPurchaseConfirmModel _model;
    [Token(Token = "0x400C0D4")]
    [FieldOffset(Offset = "0x14")]
    private UIUtility.DialogResultEvent _okEvent;
    [Token(Token = "0x400C0D5")]
    [FieldOffset(Offset = "0x18")]
    private UIUtility.DialogResultEvent _noEvent;

    [Token(Token = "0x600B671")]
    [Address(RVA = "0x7CC1A0", Offset = "0x7CAFA0", VA = "0x107CC1A0")]
    public void Setup(
      string title,
      string main,
      UIUtility.DialogResultEvent okEvent,
      UIUtility.DialogResultEvent noEvent,
      string yesText,
      string noText,
      string periodText,
      string priceText)
    {
    }

    [Token(Token = "0x600B672")]
    [Address(RVA = "0x7CC000", Offset = "0x7CAE00", VA = "0x107CC000")]
    private void Draw()
    {
    }

    [Token(Token = "0x600B673")]
    [Address(RVA = "0x7CC100", Offset = "0x7CAF00", VA = "0x107CC100")]
    private void OnWindowClose(UIWindow window)
    {
    }

    [Token(Token = "0x600B674")]
    [Address(RVA = "0x7CBF30", Offset = "0x7CAD30", VA = "0x107CBF30")]
    private void BeginClose()
    {
    }

    [Token(Token = "0x600B675")]
    [Address(RVA = "0x7CC0C0", Offset = "0x7CAEC0", VA = "0x107CC0C0")]
    private void OnClickYes(GameObject go)
    {
    }

    [Token(Token = "0x600B676")]
    [Address(RVA = "0x7CC080", Offset = "0x7CAE80", VA = "0x107CC080")]
    private void OnClickNo(GameObject go)
    {
    }

    [Token(Token = "0x600B677")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public ExpansionPurchaseConfirmWindow()
    {
    }
  }
}
