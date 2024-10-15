// Decompiled with JetBrains decompiler
// Type: SRPG.CoinConfirmWindow
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
  [Token(Token = "0x20021A0")]
  public class CoinConfirmWindow : UIDraft
  {
    [Token(Token = "0x400931B")]
    public const string CoinConfirmWindowPrefab = "UI/CoinConfirmWindow";
    [Token(Token = "0x400931C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList[] _ExhibitLists;
    [Token(Token = "0x400931D")]
    [FieldOffset(Offset = "0x10")]
    private CoinConfirmModel _model;
    [Token(Token = "0x400931E")]
    [FieldOffset(Offset = "0x14")]
    private UIUtility.DialogResultEvent _okEvent;
    [Token(Token = "0x400931F")]
    [FieldOffset(Offset = "0x18")]
    private UIUtility.DialogResultEvent _noEvent;

    [Token(Token = "0x6008D79")]
    [Address(RVA = "0x511850", Offset = "0x510650", VA = "0x10511850")]
    public void Setup(
      string title,
      string main,
      string sub,
      UIUtility.DialogResultEvent okEventListener,
      UIUtility.DialogResultEvent noEventListener,
      string yesText,
      string noText,
      bool isDisplayCoin,
      string periodText)
    {
    }

    [Token(Token = "0x6008D7A")]
    [Address(RVA = "0x5116B0", Offset = "0x5104B0", VA = "0x105116B0")]
    private void Draw()
    {
    }

    [Token(Token = "0x6008D7B")]
    [Address(RVA = "0x5117B0", Offset = "0x5105B0", VA = "0x105117B0")]
    private void OnWindowClose(UIWindow window)
    {
    }

    [Token(Token = "0x6008D7C")]
    [Address(RVA = "0x5115E0", Offset = "0x5103E0", VA = "0x105115E0")]
    private void BeginClose()
    {
    }

    [Token(Token = "0x6008D7D")]
    [Address(RVA = "0x511730", Offset = "0x510530", VA = "0x10511730")]
    private void OnClickYes(GameObject go)
    {
    }

    [Token(Token = "0x6008D7E")]
    [Address(RVA = "0x511770", Offset = "0x510570", VA = "0x10511770")]
    private void OnClickeNo(GameObject go)
    {
    }

    [Token(Token = "0x6008D7F")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public CoinConfirmWindow()
    {
    }
  }
}
