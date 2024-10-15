// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_Dialog3
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
  [Token(Token = "0x2001284")]
  [EventActionInfo("New/会話/表示3(2D)", "会話の文章を表示し、プレイヤーの入力を待ちます。", 5592405, 4473992)]
  public class Event2dAction_Dialog3 : EventAction
  {
    [Token(Token = "0x4004462")]
    private const float DialogPadding = 20f;
    [Token(Token = "0x4004463")]
    private const float normalScale = 1f;
    [Token(Token = "0x4004464")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    [HideInInspector]
    public string ActorID;
    [Token(Token = "0x4004465")]
    [FieldOffset(Offset = "0x1C")]
    public string CharaID;
    [Token(Token = "0x4004466")]
    [FieldOffset(Offset = "0x20")]
    [StringIsLocalUnitIDPopup]
    public string UnitID;
    [Token(Token = "0x4004467")]
    [FieldOffset(Offset = "0x24")]
    [StringIsTextIDPopup(false)]
    public string TextID;
    [Token(Token = "0x4004468")]
    [FieldOffset(Offset = "0x28")]
    public string Emotion;
    [Token(Token = "0x4004469")]
    [FieldOffset(Offset = "0x2C")]
    private List<GameObject> fadeInList;
    [Token(Token = "0x400446A")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> fadeOutList;
    [Token(Token = "0x400446B")]
    [FieldOffset(Offset = "0x34")]
    private List<CanvasGroup> fadeInParticleList;
    [Token(Token = "0x400446C")]
    [FieldOffset(Offset = "0x38")]
    private List<CanvasGroup> fadeOutParticleList;
    [Token(Token = "0x400446D")]
    [FieldOffset(Offset = "0x3C")]
    public bool Async;
    [Token(Token = "0x400446E")]
    [FieldOffset(Offset = "0x40")]
    private string mTextData;
    [Token(Token = "0x400446F")]
    [FieldOffset(Offset = "0x44")]
    private string mVoiceID;
    [Token(Token = "0x4004470")]
    [FieldOffset(Offset = "0x48")]
    [HideInInspector]
    public float FadeTime;
    [Token(Token = "0x4004471")]
    [FieldOffset(Offset = "0x4C")]
    private float fadingTime;
    [Token(Token = "0x4004472")]
    [FieldOffset(Offset = "0x50")]
    private bool IsFading;
    [Token(Token = "0x4004473")]
    [FieldOffset(Offset = "0x51")]
    private bool FoldOut;
    [Token(Token = "0x4004474")]
    [FieldOffset(Offset = "0x52")]
    [HideInInspector]
    public bool ActorParticle;
    [Token(Token = "0x4004475")]
    [FieldOffset(Offset = "0x54")]
    private UnitParam mUnit;
    [Token(Token = "0x4004476")]
    [FieldOffset(Offset = "0x58")]
    private EventDialogBubbleCustom mBubble;
    [Token(Token = "0x4004477")]
    [FieldOffset(Offset = "0x5C")]
    private LoadRequest mBubbleResource;
    [Token(Token = "0x4004478")]
    [FieldOffset(Offset = "0x60")]
    private RectTransform bubbleTransform;
    [Token(Token = "0x4004479")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    [HideInInspector]
    public string[] IgnoreFadeOut;
    [Token(Token = "0x400447A")]
    private const EventDialogBubbleCustom.Anchors AnchorPoint = EventDialogBubbleCustom.Anchors.BottomCenter;
    [Token(Token = "0x400447B")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;
    [Token(Token = "0x400447C")]
    [FieldOffset(Offset = "0x68")]
    private bool FoldOutShake;
    [Token(Token = "0x400447D")]
    [FieldOffset(Offset = "0x6C")]
    [HideInInspector]
    public float Duration;
    [Token(Token = "0x400447E")]
    [FieldOffset(Offset = "0x70")]
    [HideInInspector]
    public float FrequencyX;
    [Token(Token = "0x400447F")]
    [FieldOffset(Offset = "0x74")]
    [HideInInspector]
    public float FrequencyY;
    [Token(Token = "0x4004480")]
    [FieldOffset(Offset = "0x78")]
    [HideInInspector]
    public float AmplitudeX;
    [Token(Token = "0x4004481")]
    [FieldOffset(Offset = "0x7C")]
    [HideInInspector]
    public float AmplitudeY;
    [Token(Token = "0x4004482")]
    [FieldOffset(Offset = "0x80")]
    private float mSeedX;
    [Token(Token = "0x4004483")]
    [FieldOffset(Offset = "0x84")]
    private float mSeedY;
    [Token(Token = "0x4004484")]
    [FieldOffset(Offset = "0x88")]
    private float ShakingTime;
    [Token(Token = "0x4004485")]
    [FieldOffset(Offset = "0x8C")]
    private bool IsShaking;
    [Token(Token = "0x4004486")]
    [FieldOffset(Offset = "0x90")]
    private Vector2 originalPvt;

    [Token(Token = "0x6004E71")]
    [Address(RVA = "0x122A640", Offset = "0x1229440", VA = "0x1122A640")]
    private static string[] GetIDPair(string src) => (string[]) null;

    [Token(Token = "0x170008CB")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004E72"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004E73")]
    [Address(RVA = "0x122BB70", Offset = "0x122A970", VA = "0x1122BB70", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004E74")]
    [Address(RVA = "0x122B910", Offset = "0x122A710", VA = "0x1122B910", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004E75")]
    [Address(RVA = "0x122A8C0", Offset = "0x12296C0", VA = "0x1122A8C0")]
    private void LoadTextData()
    {
    }

    [Token(Token = "0x6004E76")]
    [Address(RVA = "0x1216E60", Offset = "0x1215C60", VA = "0x11216E60")]
    private Vector2 CalcBubblePosition(Vector3 position) => new Vector2();

    [Token(Token = "0x6004E77")]
    [Address(RVA = "0x12299B0", Offset = "0x12287B0", VA = "0x112299B0")]
    private bool ContainIgnoreFO(string charID) => new bool();

    [Token(Token = "0x6004E78")]
    [Address(RVA = "0x122A9C0", Offset = "0x12297C0", VA = "0x1122A9C0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E79")]
    [Address(RVA = "0x122BD20", Offset = "0x122AB20", VA = "0x1122BD20", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004E7A")]
    [Address(RVA = "0x1229A30", Offset = "0x1228830", VA = "0x11229A30")]
    private void FadeIn(float time)
    {
    }

    [Token(Token = "0x6004E7B")]
    [Address(RVA = "0x122BBD0", Offset = "0x122A9D0", VA = "0x1122BBD0")]
    private void Shake(float time)
    {
    }

    [Token(Token = "0x6004E7C")]
    [Address(RVA = "0x122A580", Offset = "0x1229380", VA = "0x1122A580")]
    private string GetActorName(string actorID) => (string) null;

    [Token(Token = "0x6004E7D")]
    [Address(RVA = "0x122A470", Offset = "0x1229270", VA = "0x1122A470", Slot = "8")]
    public override bool Forward() => new bool();

    [Token(Token = "0x6004E7E")]
    [Address(RVA = "0x122A6E0", Offset = "0x12294E0", VA = "0x1122A6E0", Slot = "17")]
    public override string[] GetUnManagedAssetListData() => (string[]) null;

    [Token(Token = "0x6004E7F")]
    [Address(RVA = "0x122BFB0", Offset = "0x122ADB0", VA = "0x1122BFB0")]
    public Event2dAction_Dialog3()
    {
    }

    [Token(Token = "0x6004E80")]
    [Address(RVA = "0x122BF40", Offset = "0x122AD40", VA = "0x1122BF40")]
    static Event2dAction_Dialog3()
    {
    }

    [Token(Token = "0x2001285")]
    public enum TextSpeedTypes
    {
      [Token(Token = "0x4004488")] Normal,
      [Token(Token = "0x4004489")] Slow,
      [Token(Token = "0x400448A")] Fast,
    }
  }
}
