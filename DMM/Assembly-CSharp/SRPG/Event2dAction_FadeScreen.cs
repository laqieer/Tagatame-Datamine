// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_FadeScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200128E")]
  [EventActionInfo("フェード(2D)", "画面をフェードイン・フェードアウトさせます", 5592405, 4473992)]
  public class Event2dAction_FadeScreen : EventAction
  {
    [Token(Token = "0x40044A6")]
    [FieldOffset(Offset = "0x18")]
    public bool FadeOut;
    [Token(Token = "0x40044A7")]
    [FieldOffset(Offset = "0x19")]
    public bool ChangeColor;
    [Token(Token = "0x40044A8")]
    [FieldOffset(Offset = "0x1A")]
    public bool Async;
    [Token(Token = "0x40044A9")]
    [FieldOffset(Offset = "0x1C")]
    public float FadeTime;
    [Token(Token = "0x40044AA")]
    [FieldOffset(Offset = "0x20")]
    private Event2dFade mEvent2dFade;
    [Token(Token = "0x40044AB")]
    [FieldOffset(Offset = "0x24")]
    private LoadRequest mResource;
    [Token(Token = "0x40044AC")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;
    [Token(Token = "0x40044AD")]
    [FieldOffset(Offset = "0x28")]
    private Color FadeInColorWhite;
    [Token(Token = "0x40044AE")]
    [FieldOffset(Offset = "0x38")]
    private Color FadeInColorBlack;

    [Token(Token = "0x170008CE")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004E9B"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004E9C")]
    [Address(RVA = "0x123E2A0", Offset = "0x123D0A0", VA = "0x1123E2A0", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004E9D")]
    [Address(RVA = "0x123E0D0", Offset = "0x123CED0", VA = "0x1123E0D0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004E9E")]
    [Address(RVA = "0x123DFB0", Offset = "0x123CDB0", VA = "0x1123DFB0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E9F")]
    [Address(RVA = "0x123E310", Offset = "0x123D110", VA = "0x1123E310")]
    private void StartFade()
    {
    }

    [Token(Token = "0x6004EA0")]
    [Address(RVA = "0x123E3C0", Offset = "0x123D1C0", VA = "0x1123E3C0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004EA1")]
    [Address(RVA = "0x123E450", Offset = "0x123D250", VA = "0x1123E450")]
    public Event2dAction_FadeScreen()
    {
    }

    [Token(Token = "0x6004EA2")]
    [Address(RVA = "0x123E400", Offset = "0x123D200", VA = "0x1123E400")]
    static Event2dAction_FadeScreen()
    {
    }
  }
}
