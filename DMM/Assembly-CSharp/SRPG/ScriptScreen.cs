// Decompiled with JetBrains decompiler
// Type: SRPG.ScriptScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Text.RegularExpressions;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A57")]
  [AddComponentMenu("UI/ScriptScreen")]
  public class ScriptScreen : MonoBehaviour
  {
    [Token(Token = "0x400CE0C")]
    [FieldOffset(Offset = "0xC")]
    public UnityEngine.UI.Text BodyText;
    [Token(Token = "0x400CE0D")]
    [FieldOffset(Offset = "0x10")]
    private bool mSkipFadeOut;
    [Token(Token = "0x400CE0E")]
    [FieldOffset(Offset = "0x14")]
    public float FadeInTime;
    [Token(Token = "0x400CE0F")]
    [FieldOffset(Offset = "0x18")]
    public float FadeOutTime;
    [Token(Token = "0x400CE10")]
    [FieldOffset(Offset = "0x1C")]
    public float FadeOutInterval;
    [Token(Token = "0x400CE11")]
    [FieldOffset(Offset = "0x20")]
    public float SkipWaitTime;
    [Token(Token = "0x400CE12")]
    [FieldOffset(Offset = "0x24")]
    private ScriptScreen.Character[] mCharacters;
    [Token(Token = "0x400CE13")]
    [FieldOffset(Offset = "0x28")]
    private int mNumCharacters;
    [Token(Token = "0x400CE14")]
    [FieldOffset(Offset = "0x2C")]
    public float NewLineInterval;
    [Token(Token = "0x400CE15")]
    [FieldOffset(Offset = "0x30")]
    [NonSerialized]
    public EventAction_Dialog.TextSpeedTypes TextSpeed;
    [Token(Token = "0x400CE16")]
    [FieldOffset(Offset = "0x34")]
    private float mStartTime;
    [Token(Token = "0x400CE17")]
    [FieldOffset(Offset = "0x38")]
    private bool mTextNeedsUpdate;
    [Token(Token = "0x400CE18")]
    [FieldOffset(Offset = "0x3C")]
    private ScriptScreen.TextParameter mTextQueue;
    [Token(Token = "0x400CE19")]
    [FieldOffset(Offset = "0x0")]
    private static Regex regEndTag;
    [Token(Token = "0x400CE1A")]
    [FieldOffset(Offset = "0x4")]
    private static Regex regColor;
    [Token(Token = "0x400CE1B")]
    [FieldOffset(Offset = "0x40")]
    private bool mFadingOut;

    [Token(Token = "0x170019D8")]
    public bool IsPrinting
    {
      [Token(Token = "0x600C12A"), Address(RVA = "0x89AC20", Offset = "0x899A20", VA = "0x1089AC20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C12B")]
    [Address(RVA = "0x899BF0", Offset = "0x8989F0", VA = "0x10899BF0")]
    private void OnBackLogButtonClicked()
    {
    }

    [Token(Token = "0x600C12C")]
    [Address(RVA = "0x89A340", Offset = "0x899140", VA = "0x1089A340")]
    public void Skip()
    {
    }

    [Token(Token = "0x600C12D")]
    [Address(RVA = "0x89A1F0", Offset = "0x898FF0", VA = "0x1089A1F0")]
    public void Reset()
    {
    }

    [Token(Token = "0x600C12E")]
    [Address(RVA = "0x89A3C0", Offset = "0x8991C0", VA = "0x1089A3C0")]
    private static ScriptScreen.Element[] SplitTags(string s) => (ScriptScreen.Element[]) null;

    [Token(Token = "0x600C12F")]
    [Address(RVA = "0x899E00", Offset = "0x898C00", VA = "0x10899E00")]
    private void Parse(ScriptScreen.Element[] c, ref int n, string end, ScriptScreen.Ctx ctx)
    {
    }

    [Token(Token = "0x600C130")]
    [Address(RVA = "0x89A060", Offset = "0x898E60", VA = "0x1089A060")]
    private void PushCharacters(string s, ScriptScreen.Ctx ctx)
    {
    }

    [Token(Token = "0x600C131")]
    [Address(RVA = "0x89A1A0", Offset = "0x898FA0", VA = "0x1089A1A0")]
    public string ReplaceText(string text) => (string) null;

    [Token(Token = "0x600C132")]
    [Address(RVA = "0x8998F0", Offset = "0x8986F0", VA = "0x108998F0")]
    private void FlushText()
    {
    }

    [Token(Token = "0x600C133")]
    [Address(RVA = "0x89A240", Offset = "0x899040", VA = "0x1089A240")]
    public void SetBody(ScriptScreen.TextParameter param)
    {
    }

    [Token(Token = "0x600C134")]
    [Address(RVA = "0x899C80", Offset = "0x898A80", VA = "0x10899C80")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600C135")]
    [Address(RVA = "0x899830", Offset = "0x898630", VA = "0x10899830")]
    private void BeginFadeOut()
    {
    }

    [Token(Token = "0x170019D9")]
    public bool Finished
    {
      [Token(Token = "0x600C136"), Address(RVA = "0x89AC00", Offset = "0x899A00", VA = "0x1089AC00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C137")]
    [Address(RVA = "0x899CA0", Offset = "0x898AA0", VA = "0x10899CA0")]
    public void Open()
    {
    }

    [Token(Token = "0x600C138")]
    [Address(RVA = "0x8998C0", Offset = "0x8986C0", VA = "0x108998C0")]
    public void Close()
    {
    }

    [Token(Token = "0x600C139")]
    [Address(RVA = "0x89A310", Offset = "0x899110", VA = "0x1089A310")]
    private void SetVisibility(bool open)
    {
    }

    [Token(Token = "0x600C13A")]
    [Address(RVA = "0x89A690", Offset = "0x899490", VA = "0x1089A690")]
    private void UpdateText()
    {
    }

    [Token(Token = "0x600C13B")]
    [Address(RVA = "0x89AAD0", Offset = "0x8998D0", VA = "0x1089AAD0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C13C")]
    [Address(RVA = "0x89A5D0", Offset = "0x8993D0", VA = "0x1089A5D0")]
    private static string StringFormat(string format, params object[] args) => (string) null;

    [Token(Token = "0x600C13D")]
    [Address(RVA = "0x89ABE0", Offset = "0x8999E0", VA = "0x1089ABE0")]
    public ScriptScreen()
    {
    }

    [Token(Token = "0x600C13E")]
    [Address(RVA = "0x89AB20", Offset = "0x899920", VA = "0x1089AB20")]
    static ScriptScreen()
    {
    }

    [Token(Token = "0x2002A58")]
    private struct Character
    {
      [Token(Token = "0x400CE1C")]
      [FieldOffset(Offset = "0x0")]
      public char Code;
      [Token(Token = "0x400CE1D")]
      [FieldOffset(Offset = "0x4")]
      public Color32 Color;
      [Token(Token = "0x400CE1E")]
      [FieldOffset(Offset = "0x8")]
      public float Interval;
      [Token(Token = "0x400CE1F")]
      [FieldOffset(Offset = "0xC")]
      public float TimeOffset;

      [Token(Token = "0x600C13F")]
      [Address(RVA = "0x5A8DA0", Offset = "0x5A7BA0", VA = "0x105A8DA0")]
      public Character(char code, Color32 color, float interval, float timeOffset)
      {
      }
    }

    [Token(Token = "0x2002A59")]
    public class TextParameter
    {
      [Token(Token = "0x400CE20")]
      [FieldOffset(Offset = "0x8")]
      public string text;
      [Token(Token = "0x400CE21")]
      [FieldOffset(Offset = "0xC")]
      public object[] args;

      [Token(Token = "0x600C140")]
      [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
      public TextParameter(string text, object[] args)
      {
      }
    }

    [Token(Token = "0x2002A5A")]
    private class Element
    {
      [Token(Token = "0x400CE22")]
      [FieldOffset(Offset = "0x8")]
      public string Tag;
      [Token(Token = "0x400CE23")]
      [FieldOffset(Offset = "0xC")]
      public string Value;

      [Token(Token = "0x600C141")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Element()
      {
      }
    }

    [Token(Token = "0x2002A5B")]
    private struct Ctx
    {
      [Token(Token = "0x400CE24")]
      [FieldOffset(Offset = "0x0")]
      public Color32 Color;
      [Token(Token = "0x400CE25")]
      [FieldOffset(Offset = "0x4")]
      public float Interval;
    }
  }
}
