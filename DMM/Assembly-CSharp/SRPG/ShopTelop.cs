// Decompiled with JetBrains decompiler
// Type: SRPG.ShopTelop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AB0")]
  [AddComponentMenu("UI/ShopTelop")]
  public class ShopTelop : MonoBehaviour
  {
    [Token(Token = "0x400D02E")]
    [FieldOffset(Offset = "0xC")]
    public Text BodyText;
    [Token(Token = "0x400D02F")]
    [FieldOffset(Offset = "0x10")]
    public float FadeInSec;
    [Token(Token = "0x400D030")]
    [FieldOffset(Offset = "0x14")]
    public float FadeInInterval;
    [Token(Token = "0x400D031")]
    [FieldOffset(Offset = "0x18")]
    public float FadeOutSec;
    [Token(Token = "0x400D032")]
    [FieldOffset(Offset = "0x1C")]
    public float FadeOutInterval;
    [Token(Token = "0x400D033")]
    [FieldOffset(Offset = "0x20")]
    public GameObject WindowAnimator;
    [Token(Token = "0x400D034")]
    [FieldOffset(Offset = "0x24")]
    public string WindowOpenProperty;
    [Token(Token = "0x400D035")]
    [FieldOffset(Offset = "0x28")]
    public string WindowOpeningState;
    [Token(Token = "0x400D036")]
    [FieldOffset(Offset = "0x2C")]
    public string WindowCloseProperty;
    [Token(Token = "0x400D037")]
    [FieldOffset(Offset = "0x30")]
    public string WindowClosingState;
    [Token(Token = "0x400D038")]
    [FieldOffset(Offset = "0x34")]
    public string WindowClosedState;
    [Token(Token = "0x400D039")]
    [FieldOffset(Offset = "0x38")]
    public string WindowLoopState;
    [Token(Token = "0x400D03A")]
    [FieldOffset(Offset = "0x3C")]
    public CanvasGroup WindowAlphaCanvasGroup;
    [Token(Token = "0x400D03B")]
    [FieldOffset(Offset = "0x40")]
    private List<ShopTelop.TextChar> chList;
    [Token(Token = "0x400D03C")]
    [FieldOffset(Offset = "0x44")]
    private float mPastSec;
    [Token(Token = "0x400D03D")]
    [FieldOffset(Offset = "0x48")]
    private ShopTelop.EState mState;
    [Token(Token = "0x400D03E")]
    [FieldOffset(Offset = "0x4C")]
    private string mNextText;
    [Token(Token = "0x400D03F")]
    [FieldOffset(Offset = "0x50")]
    private bool mNextTextUpdated;
    [Token(Token = "0x400D040")]
    [FieldOffset(Offset = "0x51")]
    private bool mFadeOut;

    [Token(Token = "0x600C2FF")]
    [Address(RVA = "0x8B5ED0", Offset = "0x8B4CD0", VA = "0x108B5ED0")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x600C300")]
    [Address(RVA = "0x7CC4A0", Offset = "0x7CB2A0", VA = "0x107CC4A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C301")]
    [Address(RVA = "0x8B5F30", Offset = "0x8B4D30", VA = "0x108B5F30")]
    private void StartTextAnim()
    {
    }

    [Token(Token = "0x600C302")]
    [Address(RVA = "0x8B6060", Offset = "0x8B4E60", VA = "0x108B6060")]
    private void StartWindowAnim(string property)
    {
    }

    [Token(Token = "0x600C303")]
    [Address(RVA = "0x8B5DC0", Offset = "0x8B4BC0", VA = "0x108B5DC0")]
    private bool IsWindowState(string state) => new bool();

    [Token(Token = "0x600C304")]
    [Address(RVA = "0x8B5D40", Offset = "0x8B4B40", VA = "0x108B5D40")]
    private bool IsCanvasGroupAlphaZero() => new bool();

    [Token(Token = "0x600C305")]
    [Address(RVA = "0x8B69C0", Offset = "0x8B57C0", VA = "0x108B69C0")]
    private bool UpdateWindowState() => new bool();

    [Token(Token = "0x600C306")]
    [Address(RVA = "0x8B6B00", Offset = "0x8B5900", VA = "0x108B6B00")]
    private void Update()
    {
    }

    [Token(Token = "0x600C307")]
    [Address(RVA = "0x8B6180", Offset = "0x8B4F80", VA = "0x108B6180")]
    private void UpdateTextAnim()
    {
    }

    [Token(Token = "0x600C308")]
    [Address(RVA = "0x8B6530", Offset = "0x8B5330", VA = "0x108B6530")]
    private void UpdateTextString()
    {
    }

    [Token(Token = "0x600C309")]
    [Address(RVA = "0x8B6330", Offset = "0x8B5130", VA = "0x108B6330")]
    private bool UpdateTextOut() => new bool();

    [Token(Token = "0x600C30A")]
    [Address(RVA = "0x8B6D40", Offset = "0x8B5B40", VA = "0x108B6D40")]
    public ShopTelop()
    {
    }

    [Token(Token = "0x2002AB1")]
    private class TextChar
    {
      [Token(Token = "0x400D041")]
      [FieldOffset(Offset = "0x8")]
      public int index;
      [Token(Token = "0x400D042")]
      [FieldOffset(Offset = "0xC")]
      public char ch;
      [Token(Token = "0x400D043")]
      [FieldOffset(Offset = "0x10")]
      public float alpha;

      [Token(Token = "0x600C30B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TextChar()
      {
      }
    }

    [Token(Token = "0x2002AB2")]
    private enum EState
    {
      [Token(Token = "0x400D045")] NOP,
      [Token(Token = "0x400D046")] ACTIVE,
    }
  }
}
