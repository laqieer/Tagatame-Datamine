// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_Dialog2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011FA")]
  [EventActionInfo("New/会話/表示", "会話の文章を表示し、プレイヤーの入力を待ちます。", 5592456, 5592490)]
  public class EventAction_Dialog2 : EventAction
  {
    [Token(Token = "0x400416A")]
    private const float DialogPadding = 20f;
    [Token(Token = "0x400416B")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x400416C")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsLocalUnitIDPopup]
    public string UnitID;
    [Token(Token = "0x400416D")]
    [FieldOffset(Offset = "0x20")]
    [StringIsTextIDPopup(true)]
    public string TextID;
    [Token(Token = "0x400416E")]
    [FieldOffset(Offset = "0x24")]
    private string mTextData;
    [Token(Token = "0x400416F")]
    [FieldOffset(Offset = "0x28")]
    private string mVoiceID;
    [Token(Token = "0x4004170")]
    [FieldOffset(Offset = "0x2C")]
    private UnitParam mUnit;
    [Token(Token = "0x4004171")]
    [FieldOffset(Offset = "0x30")]
    private EventDialogBubble mBubble;
    [Token(Token = "0x4004172")]
    [FieldOffset(Offset = "0x34")]
    private LoadRequest mBubbleResource;
    [Token(Token = "0x4004173")]
    [FieldOffset(Offset = "0x38")]
    private LoadRequest mPortraitResource;
    [Token(Token = "0x4004174")]
    [FieldOffset(Offset = "0x3C")]
    [Tooltip("非同期にするか？")]
    public bool Async;
    [Token(Token = "0x4004175")]
    [FieldOffset(Offset = "0x40")]
    [HideInInspector]
    public PortraitSet.EmotionTypes Emotion;
    [Token(Token = "0x4004176")]
    private const string ExtraEmotionDir = "ExtraEmotions/";
    [Token(Token = "0x4004177")]
    [FieldOffset(Offset = "0x44")]
    [HideInInspector]
    [StringIsResourcePath(typeof (Texture2D), "ExtraEmotions/")]
    public string CustomEmotion;
    [Token(Token = "0x4004178")]
    [FieldOffset(Offset = "0x48")]
    public EventDialogBubble.Anchors Position;
    [Token(Token = "0x4004179")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;

    [Token(Token = "0x6004C6B")]
    [Address(RVA = "0x1217090", Offset = "0x1215E90", VA = "0x11217090")]
    private static string[] GetIDPair(string src) => (string[]) null;

    [Token(Token = "0x1700087C")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004C6C"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004C6D")]
    [Address(RVA = "0x1217CC0", Offset = "0x1216AC0", VA = "0x11217CC0", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004C6E")]
    [Address(RVA = "0x1217A90", Offset = "0x1216890", VA = "0x11217A90", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004C6F")]
    [Address(RVA = "0x1217DB0", Offset = "0x1216BB0", VA = "0x11217DB0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004C70")]
    [Address(RVA = "0x12172A0", Offset = "0x12160A0", VA = "0x112172A0")]
    private void LoadTextData()
    {
    }

    [Token(Token = "0x6004C71")]
    [Address(RVA = "0x1216E60", Offset = "0x1215C60", VA = "0x11216E60")]
    private Vector2 CalcBubblePosition(Vector3 position) => new Vector2();

    [Token(Token = "0x6004C72")]
    [Address(RVA = "0x12173A0", Offset = "0x12161A0", VA = "0x112173A0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C73")]
    [Address(RVA = "0x1216FD0", Offset = "0x1215DD0", VA = "0x11216FD0")]
    private string GetActorName(string actorID) => (string) null;

    [Token(Token = "0x6004C74")]
    [Address(RVA = "0x1216F00", Offset = "0x1215D00", VA = "0x11216F00", Slot = "8")]
    public override bool Forward() => new bool();

    [Token(Token = "0x6004C75")]
    [Address(RVA = "0x1217210", Offset = "0x1216010", VA = "0x11217210", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004C76")]
    [Address(RVA = "0x1217D30", Offset = "0x1216B30", VA = "0x11217D30", Slot = "10")]
    public override void SkipImmediate()
    {
    }

    [Token(Token = "0x6004C77")]
    [Address(RVA = "0x1215590", Offset = "0x1214390", VA = "0x11215590", Slot = "18")]
    protected virtual void OnFinish()
    {
    }

    [Token(Token = "0x6004C78")]
    [Address(RVA = "0x1217180", Offset = "0x1215F80", VA = "0x11217180", Slot = "17")]
    public override string[] GetUnManagedAssetListData() => (string[]) null;

    [Token(Token = "0x6004C79")]
    [Address(RVA = "0x1217F30", Offset = "0x1216D30", VA = "0x11217F30")]
    public EventAction_Dialog2()
    {
    }

    [Token(Token = "0x6004C7A")]
    [Address(RVA = "0x1217EE0", Offset = "0x1216CE0", VA = "0x11217EE0")]
    static EventAction_Dialog2()
    {
    }

    [Token(Token = "0x20011FB")]
    public enum TextSpeedTypes
    {
      [Token(Token = "0x400417B")] Normal,
      [Token(Token = "0x400417C")] Slow,
      [Token(Token = "0x400417D")] Fast,
    }
  }
}
