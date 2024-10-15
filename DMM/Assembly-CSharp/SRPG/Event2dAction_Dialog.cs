// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_Dialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200127E")]
  [EventActionInfo("会話/表示(2D)", "会話の文章を表示し、プレイヤーの入力を待ちます。", 5592405, 4473992)]
  public class Event2dAction_Dialog : EventAction
  {
    [Token(Token = "0x400442F")]
    private const float DialogPadding = 20f;
    [Token(Token = "0x4004430")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    [HideInInspector]
    public string ActorID;
    [Token(Token = "0x4004431")]
    [FieldOffset(Offset = "0x1C")]
    public string CharaID;
    [Token(Token = "0x4004432")]
    [FieldOffset(Offset = "0x20")]
    [StringIsLocalUnitID]
    public string UnitID;
    [Token(Token = "0x4004433")]
    [FieldOffset(Offset = "0x24")]
    [StringIsTextID(false)]
    public string TextID;
    [Token(Token = "0x4004434")]
    [FieldOffset(Offset = "0x28")]
    public string Emotion;
    [Token(Token = "0x4004435")]
    [FieldOffset(Offset = "0x2C")]
    public bool Async;
    [Token(Token = "0x4004436")]
    [FieldOffset(Offset = "0x30")]
    private string mTextData;
    [Token(Token = "0x4004437")]
    [FieldOffset(Offset = "0x34")]
    private string mVoiceID;
    [Token(Token = "0x4004438")]
    [FieldOffset(Offset = "0x38")]
    private UnitParam mUnit;
    [Token(Token = "0x4004439")]
    [FieldOffset(Offset = "0x3C")]
    private string mPlayerName;
    [Token(Token = "0x400443A")]
    [FieldOffset(Offset = "0x40")]
    private EventDialogBubbleCustom mBubble;
    [Token(Token = "0x400443B")]
    [FieldOffset(Offset = "0x44")]
    private LoadRequest mBubbleResource;
    [Token(Token = "0x400443C")]
    private const EventDialogBubbleCustom.Anchors AnchorPoint = EventDialogBubbleCustom.Anchors.BottomCenter;
    [Token(Token = "0x400443D")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;

    [Token(Token = "0x6004E47")]
    [Address(RVA = "0x122C2D0", Offset = "0x122B0D0", VA = "0x1122C2D0")]
    private static string[] GetIDPair(string src) => (string[]) null;

    [Token(Token = "0x170008C5")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004E48"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004E49")]
    [Address(RVA = "0x122CFB0", Offset = "0x122BDB0", VA = "0x1122CFB0", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004E4A")]
    [Address(RVA = "0x122CD50", Offset = "0x122BB50", VA = "0x1122CD50", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004E4B")]
    [Address(RVA = "0x122C400", Offset = "0x122B200", VA = "0x1122C400")]
    private void LoadTextData()
    {
    }

    [Token(Token = "0x6004E4C")]
    [Address(RVA = "0x1216E60", Offset = "0x1215C60", VA = "0x11216E60")]
    private Vector2 CalcBubblePosition(Vector3 position) => new Vector2();

    [Token(Token = "0x6004E4D")]
    [Address(RVA = "0x122C500", Offset = "0x122B300", VA = "0x1122C500", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E4E")]
    [Address(RVA = "0x122C210", Offset = "0x122B010", VA = "0x1122C210")]
    private string GetActorName(string actorID) => (string) null;

    [Token(Token = "0x6004E4F")]
    [Address(RVA = "0x122D020", Offset = "0x122BE20", VA = "0x1122D020", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004E50")]
    [Address(RVA = "0x122C150", Offset = "0x122AF50", VA = "0x1122C150", Slot = "8")]
    public override bool Forward() => new bool();

    [Token(Token = "0x6004E51")]
    [Address(RVA = "0x122CCC0", Offset = "0x122BAC0", VA = "0x1122CCC0", Slot = "9")]
    public override bool OnEventSkip() => new bool();

    [Token(Token = "0x6004E52")]
    [Address(RVA = "0x122CD40", Offset = "0x122BB40", VA = "0x1122CD40", Slot = "18")]
    protected virtual void OnFinish()
    {
    }

    [Token(Token = "0x6004E53")]
    [Address(RVA = "0x122C370", Offset = "0x122B170", VA = "0x1122C370", Slot = "17")]
    public override string[] GetUnManagedAssetListData() => (string[]) null;

    [Token(Token = "0x6004E54")]
    [Address(RVA = "0x122D1B0", Offset = "0x122BFB0", VA = "0x1122D1B0")]
    public Event2dAction_Dialog()
    {
    }

    [Token(Token = "0x6004E55")]
    [Address(RVA = "0x122D160", Offset = "0x122BF60", VA = "0x1122D160")]
    static Event2dAction_Dialog()
    {
    }

    [Token(Token = "0x200127F")]
    public enum TextSpeedTypes
    {
      [Token(Token = "0x400443F")] Normal,
      [Token(Token = "0x4004440")] Slow,
      [Token(Token = "0x4004441")] Fast,
    }
  }
}
