// Decompiled with JetBrains decompiler
// Type: SRPG.EventDialogBubble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002365")]
  [AddComponentMenu("UI/EventDialogBubble")]
  public class EventDialogBubble : MonoBehaviour
  {
    [Token(Token = "0x4009EBF")]
    [FieldOffset(Offset = "0x0")]
    public static List<EventDialogBubble> Instances;
    [Token(Token = "0x4009EC0")]
    public const float TopMargin = 30f;
    [Token(Token = "0x4009EC1")]
    public const float BottomMargin = 20f;
    [Token(Token = "0x4009EC2")]
    public const float LeftMargin = 20f;
    [Token(Token = "0x4009EC3")]
    public const float RightMargin = 20f;
    [Token(Token = "0x4009EC4")]
    [FieldOffset(Offset = "0xC")]
    public RawImage PortraitFront;
    [Token(Token = "0x4009EC5")]
    [FieldOffset(Offset = "0x10")]
    public UnityEngine.UI.Text NameText;
    [Token(Token = "0x4009EC6")]
    [FieldOffset(Offset = "0x14")]
    public UnityEngine.UI.Text BodyText;
    [Token(Token = "0x4009EC7")]
    [FieldOffset(Offset = "0x18")]
    [NonSerialized]
    public Texture2D CustomEmotion;
    [Token(Token = "0x4009EC8")]
    [FieldOffset(Offset = "0x1C")]
    private PortraitSet mPortraitSet;
    [Token(Token = "0x4009EC9")]
    [FieldOffset(Offset = "0x20")]
    private PortraitSet.EmotionTypes mDesiredEmotion;
    [Token(Token = "0x4009ECA")]
    [FieldOffset(Offset = "0x24")]
    private PortraitSet.EmotionTypes mCurrentEmotion;
    [Token(Token = "0x4009ECB")]
    [FieldOffset(Offset = "0x28")]
    public string VisibilityBoolName;
    [Token(Token = "0x4009ECC")]
    [FieldOffset(Offset = "0x2C")]
    public Animator BubbleAnimator;
    [Token(Token = "0x4009ECD")]
    [FieldOffset(Offset = "0x30")]
    public string OpenedStateName;
    [Token(Token = "0x4009ECE")]
    [FieldOffset(Offset = "0x34")]
    public string ClosedStateName;
    [Token(Token = "0x4009ECF")]
    [FieldOffset(Offset = "0x38")]
    [NonSerialized]
    public string BubbleID;
    [Token(Token = "0x4009ED0")]
    [FieldOffset(Offset = "0x3C")]
    private bool mCloseAndDestroy;
    [Token(Token = "0x4009ED3")]
    [FieldOffset(Offset = "0x48")]
    private MySound.Voice mVoice;
    [Token(Token = "0x4009ED4")]
    [FieldOffset(Offset = "0x4C")]
    private readonly float VoiceFadeOutSec;
    [Token(Token = "0x4009ED5")]
    [FieldOffset(Offset = "0x50")]
    private bool mSkipFadeOut;
    [Token(Token = "0x4009ED6")]
    [FieldOffset(Offset = "0x54")]
    public float FadeInTime;
    [Token(Token = "0x4009ED7")]
    [FieldOffset(Offset = "0x58")]
    public float FadeOutTime;
    [Token(Token = "0x4009ED8")]
    [FieldOffset(Offset = "0x5C")]
    public float FadeOutInterval;
    [Token(Token = "0x4009ED9")]
    [FieldOffset(Offset = "0x60")]
    private EventDialogBubble.Character[] mCharacters;
    [Token(Token = "0x4009EDA")]
    [FieldOffset(Offset = "0x64")]
    private int mNumCharacters;
    [Token(Token = "0x4009EDB")]
    [FieldOffset(Offset = "0x68")]
    public float NewLineInterval;
    [Token(Token = "0x4009EDC")]
    [FieldOffset(Offset = "0x6C")]
    [NonSerialized]
    public EventAction_Dialog.TextSpeedTypes TextSpeed;
    [Token(Token = "0x4009EDD")]
    [FieldOffset(Offset = "0x70")]
    public bool AutoExpandWidth;
    [Token(Token = "0x4009EDE")]
    [FieldOffset(Offset = "0x74")]
    public float MaxBodyTextWidth;
    [Token(Token = "0x4009EDF")]
    [FieldOffset(Offset = "0x78")]
    private float mBaseWidth;
    [Token(Token = "0x4009EE0")]
    [FieldOffset(Offset = "0x7C")]
    private float mStartTime;
    [Token(Token = "0x4009EE1")]
    [FieldOffset(Offset = "0x80")]
    private bool mTextNeedsUpdate;
    [Token(Token = "0x4009EE2")]
    [FieldOffset(Offset = "0x84")]
    private string mTextQueue;
    [Token(Token = "0x4009EE3")]
    [FieldOffset(Offset = "0x4")]
    private static Regex regEndTag;
    [Token(Token = "0x4009EE4")]
    [FieldOffset(Offset = "0x8")]
    private static Regex regColor;
    [Token(Token = "0x4009EE5")]
    [FieldOffset(Offset = "0x88")]
    private bool mFadingOut;
    [Token(Token = "0x4009EE6")]
    [FieldOffset(Offset = "0x89")]
    private bool mShouldOpen;
    [Token(Token = "0x4009EE7")]
    [FieldOffset(Offset = "0x8C")]
    private EventDialogBubble.Anchors mAnchor;

    [Token(Token = "0x1700154C")]
    public PortraitSet PortraitSet
    {
      [Token(Token = "0x60098A3"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
      [Token(Token = "0x60098A4"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (PortraitSet) null;
      }
    }

    [Token(Token = "0x1700154D")]
    public PortraitSet.EmotionTypes Emotion
    {
      [Token(Token = "0x60098A5"), Address(RVA = "0x5B8920", Offset = "0x5B7720", VA = "0x105B8920")] set
      {
      }
      [Token(Token = "0x60098A6"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new PortraitSet.EmotionTypes();
      }
    }

    [Token(Token = "0x1700154E")]
    public string VoiceSheetName
    {
      [Token(Token = "0x60098A7"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098A8"), Address(RVA = "0x36F630", Offset = "0x36E430", VA = "0x1036F630")] set
      {
      }
    }

    [Token(Token = "0x1700154F")]
    public string VoiceCueName
    {
      [Token(Token = "0x60098A9"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098AA"), Address(RVA = "0x2886E0", Offset = "0x2874E0", VA = "0x102886E0")] set
      {
      }
    }

    [Token(Token = "0x17001550")]
    public bool IsVoicePlaying
    {
      [Token(Token = "0x60098AB"), Address(RVA = "0x5B8440", Offset = "0x5B7240", VA = "0x105B8440")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60098AC")]
    [Address(RVA = "0x5B66D0", Offset = "0x5B54D0", VA = "0x105B66D0")]
    public static EventDialogBubble Find(string id) => (EventDialogBubble) null;

    [Token(Token = "0x60098AD")]
    [Address(RVA = "0x5B6480", Offset = "0x5B5280", VA = "0x105B6480")]
    public static void DiscardAll()
    {
    }

    [Token(Token = "0x60098AE")]
    [Address(RVA = "0x5B78B0", Offset = "0x5B66B0", VA = "0x105B78B0")]
    private void UpdatePortrait()
    {
    }

    [Token(Token = "0x60098AF")]
    [Address(RVA = "0x5B6130", Offset = "0x5B4F30", VA = "0x105B6130")]
    private void Awake()
    {
    }

    [Token(Token = "0x60098B0")]
    [Address(RVA = "0x5B6CA0", Offset = "0x5B5AA0", VA = "0x105B6CA0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60098B1")]
    [Address(RVA = "0x5B6680", Offset = "0x5B5480", VA = "0x105B6680")]
    private void FadeOutVoice()
    {
    }

    [Token(Token = "0x60098B2")]
    [Address(RVA = "0x5B7870", Offset = "0x5B6670", VA = "0x105B7870")]
    public void StopVoice()
    {
    }

    [Token(Token = "0x17001551")]
    public bool IsPrinting
    {
      [Token(Token = "0x60098B3"), Address(RVA = "0x5B8410", Offset = "0x5B7210", VA = "0x105B8410")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60098B4")]
    [Address(RVA = "0x5B7580", Offset = "0x5B6380", VA = "0x105B7580")]
    public void Skip()
    {
    }

    [Token(Token = "0x60098B5")]
    [Address(RVA = "0x5B5E70", Offset = "0x5B4C70", VA = "0x105B5E70")]
    public void AdjustWidth(string bodyText)
    {
    }

    [Token(Token = "0x60098B6")]
    [Address(RVA = "0x5B74C0", Offset = "0x5B62C0", VA = "0x105B74C0")]
    public void SetName(string name)
    {
    }

    [Token(Token = "0x17001552")]
    public string Name
    {
      [Token(Token = "0x60098B7"), Address(RVA = "0x5B8470", Offset = "0x5B7270", VA = "0x105B8470")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001553")]
    public string Text
    {
      [Token(Token = "0x60098B8"), Address(RVA = "0x5B8500", Offset = "0x5B7300", VA = "0x105B8500")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60098B9")]
    [Address(RVA = "0x5B6BB0", Offset = "0x5B59B0", VA = "0x105B6BB0")]
    private void OnBackLogButtonClicked()
    {
    }

    [Token(Token = "0x60098BA")]
    [Address(RVA = "0x5B7650", Offset = "0x5B6450", VA = "0x105B7650")]
    private static EventDialogBubble.Element[] SplitTags(string s)
    {
      return (EventDialogBubble.Element[]) null;
    }

    [Token(Token = "0x60098BB")]
    [Address(RVA = "0x5B6FF0", Offset = "0x5B5DF0", VA = "0x105B6FF0")]
    private void Parse(
      EventDialogBubble.Element[] c,
      ref int n,
      string end,
      EventDialogBubble.Ctx ctx)
    {
    }

    [Token(Token = "0x60098BC")]
    [Address(RVA = "0x5B7250", Offset = "0x5B6050", VA = "0x105B7250")]
    private void PushCharacters(string s, EventDialogBubble.Ctx ctx)
    {
    }

    [Token(Token = "0x60098BD")]
    [Address(RVA = "0x5B7390", Offset = "0x5B6190", VA = "0x105B7390")]
    public string ReplaceText(string text) => (string) null;

    [Token(Token = "0x60098BE")]
    [Address(RVA = "0x5B67E0", Offset = "0x5B55E0", VA = "0x105B67E0")]
    private void FlushText()
    {
    }

    [Token(Token = "0x60098BF")]
    [Address(RVA = "0x5B73E0", Offset = "0x5B61E0", VA = "0x105B73E0")]
    public void SetBody(string text)
    {
    }

    [Token(Token = "0x60098C0")]
    [Address(RVA = "0x5B6E30", Offset = "0x5B5C30", VA = "0x105B6E30")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60098C1")]
    [Address(RVA = "0x5B7860", Offset = "0x5B6660", VA = "0x105B7860")]
    private void Start()
    {
    }

    [Token(Token = "0x60098C2")]
    [Address(RVA = "0x5B6360", Offset = "0x5B5160", VA = "0x105B6360")]
    private void BeginFadeOut()
    {
    }

    [Token(Token = "0x17001554")]
    public bool Finished
    {
      [Token(Token = "0x60098C3"), Address(RVA = "0x5B83F0", Offset = "0x5B71F0", VA = "0x105B83F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60098C4")]
    [Address(RVA = "0x5B6E50", Offset = "0x5B5C50", VA = "0x105B6E50")]
    public void Open()
    {
    }

    [Token(Token = "0x60098C5")]
    [Address(RVA = "0x5B6400", Offset = "0x5B5200", VA = "0x105B6400")]
    public void Close()
    {
    }

    [Token(Token = "0x60098C6")]
    [Address(RVA = "0x5B7540", Offset = "0x5B6340", VA = "0x105B7540")]
    private void SetVisibility(bool open)
    {
    }

    [Token(Token = "0x60098C7")]
    [Address(RVA = "0x5B6B20", Offset = "0x5B5920", VA = "0x105B6B20")]
    public void Forward()
    {
    }

    [Token(Token = "0x60098C8")]
    [Address(RVA = "0x5B7A50", Offset = "0x5B6850", VA = "0x105B7A50")]
    private void UpdateText()
    {
    }

    [Token(Token = "0x60098C9")]
    [Address(RVA = "0x5B79D0", Offset = "0x5B67D0", VA = "0x105B79D0")]
    private void UpdateStateBool()
    {
    }

    [Token(Token = "0x60098CA")]
    [Address(RVA = "0x5B7EC0", Offset = "0x5B6CC0", VA = "0x105B7EC0")]
    private void Update()
    {
    }

    [Token(Token = "0x17001555")]
    public EventDialogBubble.Anchors Anchor
    {
      [Token(Token = "0x60098CB"), Address(RVA = "0x5B8590", Offset = "0x5B7390", VA = "0x105B8590")] set
      {
      }
      [Token(Token = "0x60098CC"), Address(RVA = "0x2B5F90", Offset = "0x2B4D90", VA = "0x102B5F90")] get
      {
        return new EventDialogBubble.Anchors();
      }
    }

    [Token(Token = "0x60098CD")]
    [Address(RVA = "0x5B8330", Offset = "0x5B7130", VA = "0x105B8330")]
    public EventDialogBubble()
    {
    }

    [Token(Token = "0x60098CE")]
    [Address(RVA = "0x5B8210", Offset = "0x5B7010", VA = "0x105B8210")]
    static EventDialogBubble()
    {
    }

    [Token(Token = "0x2002366")]
    private struct Character
    {
      [Token(Token = "0x4009EE8")]
      [FieldOffset(Offset = "0x0")]
      public char Code;
      [Token(Token = "0x4009EE9")]
      [FieldOffset(Offset = "0x4")]
      public Color32 Color;
      [Token(Token = "0x4009EEA")]
      [FieldOffset(Offset = "0x8")]
      public float Interval;
      [Token(Token = "0x4009EEB")]
      [FieldOffset(Offset = "0xC")]
      public float TimeOffset;

      [Token(Token = "0x60098CF")]
      [Address(RVA = "0x5A8DA0", Offset = "0x5A7BA0", VA = "0x105A8DA0")]
      public Character(char code, Color32 color, float interval, float timeOffset)
      {
      }
    }

    [Token(Token = "0x2002367")]
    private class Element
    {
      [Token(Token = "0x4009EEC")]
      [FieldOffset(Offset = "0x8")]
      public string Tag;
      [Token(Token = "0x4009EED")]
      [FieldOffset(Offset = "0xC")]
      public string Value;

      [Token(Token = "0x60098D0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Element()
      {
      }
    }

    [Token(Token = "0x2002368")]
    private struct Ctx
    {
      [Token(Token = "0x4009EEE")]
      [FieldOffset(Offset = "0x0")]
      public Color32 Color;
      [Token(Token = "0x4009EEF")]
      [FieldOffset(Offset = "0x4")]
      public float Interval;
    }

    [Token(Token = "0x2002369")]
    public enum Anchors
    {
      [Token(Token = "0x4009EF1")] None,
      [Token(Token = "0x4009EF2")] TopLeft,
      [Token(Token = "0x4009EF3")] TopCenter,
      [Token(Token = "0x4009EF4")] TopRight,
      [Token(Token = "0x4009EF5")] MiddleLeft,
      [Token(Token = "0x4009EF6")] Center,
      [Token(Token = "0x4009EF7")] MiddleRight,
      [Token(Token = "0x4009EF8")] BottomLeft,
      [Token(Token = "0x4009EF9")] BottomCenter,
      [Token(Token = "0x4009EFA")] BottomRight,
    }
  }
}
