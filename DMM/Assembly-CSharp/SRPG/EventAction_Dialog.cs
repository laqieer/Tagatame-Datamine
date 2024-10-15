// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_Dialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011F7")]
  [EventActionInfo("会話/表示", "会話の文章を表示し、プレイヤーの入力を待ちます。", 5592456, 5592490)]
  public class EventAction_Dialog : EventAction
  {
    [Token(Token = "0x4004154")]
    private const float DialogPadding = 20f;
    [Token(Token = "0x4004155")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string ActorID;
    [Token(Token = "0x4004156")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsUnitID]
    public string UnitID;
    [Token(Token = "0x4004157")]
    [FieldOffset(Offset = "0x20")]
    [StringIsTextID(true)]
    public string TextID;
    [Token(Token = "0x4004158")]
    [FieldOffset(Offset = "0x24")]
    private string mTextData;
    [Token(Token = "0x4004159")]
    [FieldOffset(Offset = "0x28")]
    private string mVoiceID;
    [Token(Token = "0x400415A")]
    [FieldOffset(Offset = "0x2C")]
    private UnitParam mUnit;
    [Token(Token = "0x400415B")]
    [FieldOffset(Offset = "0x30")]
    private EventDialogBubble mBubble;
    [Token(Token = "0x400415C")]
    [FieldOffset(Offset = "0x34")]
    private LoadRequest mBubbleResource;
    [Token(Token = "0x400415D")]
    [FieldOffset(Offset = "0x38")]
    private LoadRequest mPortraitResource;
    [Token(Token = "0x400415E")]
    [FieldOffset(Offset = "0x3C")]
    [HideInInspector]
    public PortraitSet.EmotionTypes Emotion;
    [Token(Token = "0x400415F")]
    private const string ExtraEmotionDir = "ExtraEmotions/";
    [Token(Token = "0x4004160")]
    [FieldOffset(Offset = "0x40")]
    [HideInInspector]
    [StringIsResourcePath(typeof (Texture2D), "ExtraEmotions/")]
    public string CustomEmotion;
    [Token(Token = "0x4004161")]
    [FieldOffset(Offset = "0x44")]
    public EventDialogBubble.Anchors Position;
    [Token(Token = "0x4004162")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;

    [Token(Token = "0x6004C54")]
    [Address(RVA = "0x1218140", Offset = "0x1216F40", VA = "0x11218140")]
    private static string[] GetIDPair(string src) => (string[]) null;

    [Token(Token = "0x17000879")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004C55"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004C56")]
    [Address(RVA = "0x1218DE0", Offset = "0x1217BE0", VA = "0x11218DE0", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004C57")]
    [Address(RVA = "0x1218BB0", Offset = "0x12179B0", VA = "0x11218BB0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004C58")]
    [Address(RVA = "0x1218ED0", Offset = "0x1217CD0", VA = "0x11218ED0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004C59")]
    [Address(RVA = "0x1218350", Offset = "0x1217150", VA = "0x11218350")]
    private void LoadTextData()
    {
    }

    [Token(Token = "0x6004C5A")]
    [Address(RVA = "0x1216E60", Offset = "0x1215C60", VA = "0x11216E60")]
    private Vector2 CalcBubblePosition(Vector3 position) => new Vector2();

    [Token(Token = "0x6004C5B")]
    [Address(RVA = "0x1218450", Offset = "0x1217250", VA = "0x11218450", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C5C")]
    [Address(RVA = "0x1218080", Offset = "0x1216E80", VA = "0x11218080")]
    private string GetActorName(string actorID) => (string) null;

    [Token(Token = "0x6004C5D")]
    [Address(RVA = "0x1217FC0", Offset = "0x1216DC0", VA = "0x11217FC0", Slot = "8")]
    public override bool Forward() => new bool();

    [Token(Token = "0x6004C5E")]
    [Address(RVA = "0x1218B30", Offset = "0x1217930", VA = "0x11218B30", Slot = "9")]
    public override bool OnEventSkip() => new bool();

    [Token(Token = "0x6004C5F")]
    [Address(RVA = "0x12182C0", Offset = "0x12170C0", VA = "0x112182C0", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004C60")]
    [Address(RVA = "0x1218E50", Offset = "0x1217C50", VA = "0x11218E50", Slot = "10")]
    public override void SkipImmediate()
    {
    }

    [Token(Token = "0x6004C61")]
    [Address(RVA = "0x1215590", Offset = "0x1214390", VA = "0x11215590", Slot = "18")]
    protected virtual void OnFinish()
    {
    }

    [Token(Token = "0x6004C62")]
    [Address(RVA = "0x1218230", Offset = "0x1217030", VA = "0x11218230", Slot = "17")]
    public override string[] GetUnManagedAssetListData() => (string[]) null;

    [Token(Token = "0x6004C63")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public EventAction_Dialog()
    {
    }

    [Token(Token = "0x6004C64")]
    [Address(RVA = "0x1219000", Offset = "0x1217E00", VA = "0x11219000")]
    static EventAction_Dialog()
    {
    }

    [Token(Token = "0x20011F8")]
    public enum TextSpeedTypes
    {
      [Token(Token = "0x4004164")] Normal,
      [Token(Token = "0x4004165")] Slow,
      [Token(Token = "0x4004166")] Fast,
    }
  }
}
