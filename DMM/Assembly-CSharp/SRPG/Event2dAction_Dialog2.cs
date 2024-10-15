// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_Dialog2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001281")]
  [EventActionInfo("New/会話/表示2(2D)", "会話の文章を表示し、プレイヤーの入力を待ちます。", 5592405, 4473992)]
  public class Event2dAction_Dialog2 : EventAction
  {
    [Token(Token = "0x4004445")]
    private const float DialogPadding = 20f;
    [Token(Token = "0x4004446")]
    private const float normalScale = 1f;
    [Token(Token = "0x4004447")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    [HideInInspector]
    public string ActorID;
    [Token(Token = "0x4004448")]
    [FieldOffset(Offset = "0x1C")]
    public string CharaID;
    [Token(Token = "0x4004449")]
    [FieldOffset(Offset = "0x20")]
    [StringIsLocalUnitID]
    public string UnitID;
    [Token(Token = "0x400444A")]
    [FieldOffset(Offset = "0x24")]
    [StringIsTextID(false)]
    public string TextID;
    [Token(Token = "0x400444B")]
    [FieldOffset(Offset = "0x28")]
    public string Emotion;
    [Token(Token = "0x400444C")]
    [FieldOffset(Offset = "0x2C")]
    private List<GameObject> fadeInList;
    [Token(Token = "0x400444D")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> fadeOutList;
    [Token(Token = "0x400444E")]
    [FieldOffset(Offset = "0x34")]
    public bool Async;
    [Token(Token = "0x400444F")]
    [FieldOffset(Offset = "0x38")]
    private string mTextData;
    [Token(Token = "0x4004450")]
    [FieldOffset(Offset = "0x3C")]
    private string mVoiceID;
    [Token(Token = "0x4004451")]
    [FieldOffset(Offset = "0x40")]
    [HideInInspector]
    public float FadeTime;
    [Token(Token = "0x4004452")]
    [FieldOffset(Offset = "0x44")]
    public bool Fade;
    [Token(Token = "0x4004453")]
    [FieldOffset(Offset = "0x45")]
    private bool IsFading;
    [Token(Token = "0x4004454")]
    [FieldOffset(Offset = "0x48")]
    private UnitParam mUnit;
    [Token(Token = "0x4004455")]
    [FieldOffset(Offset = "0x4C")]
    private string mPlayerName;
    [Token(Token = "0x4004456")]
    [FieldOffset(Offset = "0x50")]
    private EventDialogBubbleCustom mBubble;
    [Token(Token = "0x4004457")]
    [FieldOffset(Offset = "0x54")]
    private LoadRequest mBubbleResource;
    [Token(Token = "0x4004458")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [HideInInspector]
    public string[] IgnoreFadeOut;
    [Token(Token = "0x4004459")]
    private const EventDialogBubbleCustom.Anchors AnchorPoint = EventDialogBubbleCustom.Anchors.BottomCenter;
    [Token(Token = "0x400445A")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;

    [Token(Token = "0x6004E5C")]
    [Address(RVA = "0x1228690", Offset = "0x1227490", VA = "0x11228690")]
    private static string[] GetIDPair(string src) => (string[]) null;

    [Token(Token = "0x170008C8")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004E5D"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004E5E")]
    [Address(RVA = "0x1229650", Offset = "0x1228450", VA = "0x11229650", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004E5F")]
    [Address(RVA = "0x12293F0", Offset = "0x12281F0", VA = "0x112293F0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004E60")]
    [Address(RVA = "0x12287C0", Offset = "0x12275C0", VA = "0x112287C0")]
    private void LoadTextData()
    {
    }

    [Token(Token = "0x6004E61")]
    [Address(RVA = "0x1216E60", Offset = "0x1215C60", VA = "0x11216E60")]
    private Vector2 CalcBubblePosition(Vector3 position) => new Vector2();

    [Token(Token = "0x6004E62")]
    [Address(RVA = "0x1227EB0", Offset = "0x1226CB0", VA = "0x11227EB0")]
    private bool ContainIgnoreFO(string charID) => new bool();

    [Token(Token = "0x6004E63")]
    [Address(RVA = "0x12288C0", Offset = "0x12276C0", VA = "0x112288C0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E64")]
    [Address(RVA = "0x12296C0", Offset = "0x12284C0", VA = "0x112296C0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004E65")]
    [Address(RVA = "0x1227F30", Offset = "0x1226D30", VA = "0x11227F30")]
    private void FadeIn(float time)
    {
    }

    [Token(Token = "0x6004E66")]
    [Address(RVA = "0x12285D0", Offset = "0x12273D0", VA = "0x112285D0")]
    private string GetActorName(string actorID) => (string) null;

    [Token(Token = "0x6004E67")]
    [Address(RVA = "0x1228510", Offset = "0x1227310", VA = "0x11228510", Slot = "8")]
    public override bool Forward() => new bool();

    [Token(Token = "0x6004E68")]
    [Address(RVA = "0x1228730", Offset = "0x1227530", VA = "0x11228730", Slot = "17")]
    public override string[] GetUnManagedAssetListData() => (string[]) null;

    [Token(Token = "0x6004E69")]
    [Address(RVA = "0x12298A0", Offset = "0x12286A0", VA = "0x112298A0")]
    public Event2dAction_Dialog2()
    {
    }

    [Token(Token = "0x6004E6A")]
    [Address(RVA = "0x1229850", Offset = "0x1228650", VA = "0x11229850")]
    static Event2dAction_Dialog2()
    {
    }

    [Token(Token = "0x2001282")]
    public enum TextSpeedTypes
    {
      [Token(Token = "0x400445C")] Normal,
      [Token(Token = "0x400445D")] Slow,
      [Token(Token = "0x400445E")] Fast,
    }
  }
}
