// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_Telop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012BB")]
  [EventActionInfo("会話/テロップ(2D)", "会話の文章を表示し、プレイヤーの入力を待ちます。", 5592405, 4473992)]
  public class Event2dAction_Telop : EventAction
  {
    [Token(Token = "0x40045D8")]
    private const float DialogPadding = 20f;
    [Token(Token = "0x40045D9")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public string ActorID;
    [Token(Token = "0x40045DA")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsTextIDPopup(false)]
    public string TextID;
    [Token(Token = "0x40045DB")]
    [FieldOffset(Offset = "0x20")]
    public bool TextColor;
    [Token(Token = "0x40045DC")]
    [FieldOffset(Offset = "0x24")]
    public Event2dAction_Telop.TextPositionTypes TextPosition;
    [Token(Token = "0x40045DD")]
    [FieldOffset(Offset = "0x28")]
    private string mTextData;
    [Token(Token = "0x40045DE")]
    [FieldOffset(Offset = "0x2C")]
    private EventTelopBubble mBubble;
    [Token(Token = "0x40045DF")]
    [FieldOffset(Offset = "0x30")]
    private LoadRequest mBubbleResource;
    [Token(Token = "0x40045E0")]
    [FieldOffset(Offset = "0x34")]
    private LoadRequest mPortraitResource;
    [Token(Token = "0x40045E1")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;

    [Token(Token = "0x170008EB")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004F6F"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004F70")]
    [Address(RVA = "0x12486A0", Offset = "0x12474A0", VA = "0x112486A0", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004F71")]
    [Address(RVA = "0x1248480", Offset = "0x1247280", VA = "0x11248480", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004F72")]
    [Address(RVA = "0x1216E60", Offset = "0x1215C60", VA = "0x11216E60")]
    private Vector2 CalcBubblePosition(Vector3 position) => new Vector2();

    [Token(Token = "0x6004F73")]
    [Address(RVA = "0x1248110", Offset = "0x1246F10", VA = "0x11248110", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F74")]
    [Address(RVA = "0x1248050", Offset = "0x1246E50", VA = "0x11248050")]
    private string GetActorName(string actorID) => (string) null;

    [Token(Token = "0x6004F75")]
    [Address(RVA = "0x1247F90", Offset = "0x1246D90", VA = "0x11247F90", Slot = "8")]
    public override bool Forward() => new bool();

    [Token(Token = "0x6004F76")]
    [Address(RVA = "0x1248760", Offset = "0x1247560", VA = "0x11248760")]
    public Event2dAction_Telop()
    {
    }

    [Token(Token = "0x6004F77")]
    [Address(RVA = "0x1248710", Offset = "0x1247510", VA = "0x11248710")]
    static Event2dAction_Telop()
    {
    }

    [Token(Token = "0x20012BC")]
    public enum TextPositionTypes
    {
      [Token(Token = "0x40045E3")] Left,
      [Token(Token = "0x40045E4")] Center,
      [Token(Token = "0x40045E5")] Right,
    }

    [Token(Token = "0x20012BD")]
    public enum TextSpeedTypes
    {
      [Token(Token = "0x40045E7")] Normal,
      [Token(Token = "0x40045E8")] Slow,
      [Token(Token = "0x40045E9")] Fast,
    }
  }
}
