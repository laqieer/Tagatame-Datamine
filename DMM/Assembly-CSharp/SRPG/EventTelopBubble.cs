// Decompiled with JetBrains decompiler
// Type: SRPG.EventTelopBubble
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
  [Token(Token = "0x20023A5")]
  [AddComponentMenu("UI/EventTelopBubble")]
  public class EventTelopBubble : MonoBehaviour
  {
    [Token(Token = "0x400A0DE")]
    [FieldOffset(Offset = "0x0")]
    public static List<EventTelopBubble> Instances;
    [Token(Token = "0x400A0DF")]
    [FieldOffset(Offset = "0xC")]
    public RawImage PortraitFront;
    [Token(Token = "0x400A0E0")]
    [FieldOffset(Offset = "0x10")]
    public RawImage PortraitBack;
    [Token(Token = "0x400A0E1")]
    [FieldOffset(Offset = "0x14")]
    public UnityEngine.UI.Text NameText;
    [Token(Token = "0x400A0E2")]
    [FieldOffset(Offset = "0x18")]
    public UnityEngine.UI.Text BodyText;
    [Token(Token = "0x400A0E3")]
    [FieldOffset(Offset = "0x1C")]
    public float PortraitTransitionTime;
    [Token(Token = "0x400A0E4")]
    [FieldOffset(Offset = "0x20")]
    public bool TextColor;
    [Token(Token = "0x400A0E5")]
    [FieldOffset(Offset = "0x24")]
    public Event2dAction_Telop.TextPositionTypes TextPosition;
    [Token(Token = "0x400A0E6")]
    [FieldOffset(Offset = "0x28")]
    private bool mPortraitInitialized;
    [Token(Token = "0x400A0E7")]
    [FieldOffset(Offset = "0x2C")]
    public Texture2D CustomEmotion;
    [Token(Token = "0x400A0E8")]
    [FieldOffset(Offset = "0x30")]
    private PortraitSet mPortraitSet;
    [Token(Token = "0x400A0E9")]
    [FieldOffset(Offset = "0x34")]
    [NonSerialized]
    public PortraitSet.EmotionTypes Emotion;
    [Token(Token = "0x400A0EA")]
    [FieldOffset(Offset = "0x38")]
    private PortraitSet.EmotionTypes mCurrentEmotion;
    [Token(Token = "0x400A0EB")]
    [FieldOffset(Offset = "0x3C")]
    private float mPortraitTransition;
    [Token(Token = "0x400A0EC")]
    [FieldOffset(Offset = "0x40")]
    public string VisibilityBoolName;
    [Token(Token = "0x400A0ED")]
    [FieldOffset(Offset = "0x44")]
    public Animator BubbleAnimator;
    [Token(Token = "0x400A0EE")]
    [FieldOffset(Offset = "0x48")]
    public string OpenedStateName;
    [Token(Token = "0x400A0EF")]
    [FieldOffset(Offset = "0x4C")]
    public string ClosedStateName;
    [Token(Token = "0x400A0F0")]
    [FieldOffset(Offset = "0x50")]
    [NonSerialized]
    public string BubbleID;
    [Token(Token = "0x400A0F1")]
    [FieldOffset(Offset = "0x54")]
    private bool mCloseAndDestroy;
    [Token(Token = "0x400A0F2")]
    [FieldOffset(Offset = "0x55")]
    private bool mSkipFadeOut;
    [Token(Token = "0x400A0F3")]
    [FieldOffset(Offset = "0x58")]
    public float FadeInTime;
    [Token(Token = "0x400A0F4")]
    [FieldOffset(Offset = "0x5C")]
    public float FadeOutTime;
    [Token(Token = "0x400A0F5")]
    [FieldOffset(Offset = "0x60")]
    public float FadeOutInterval;
    [Token(Token = "0x400A0F6")]
    [FieldOffset(Offset = "0x64")]
    private EventTelopBubble.Character[] mCharacters;
    [Token(Token = "0x400A0F7")]
    [FieldOffset(Offset = "0x68")]
    private int mNumCharacters;
    [Token(Token = "0x400A0F8")]
    [FieldOffset(Offset = "0x6C")]
    public float NewLineInterval;
    [Token(Token = "0x400A0F9")]
    [FieldOffset(Offset = "0x70")]
    [NonSerialized]
    public EventAction_Dialog.TextSpeedTypes TextSpeed;
    [Token(Token = "0x400A0FA")]
    [FieldOffset(Offset = "0x74")]
    public bool AutoExpandWidth;
    [Token(Token = "0x400A0FB")]
    [FieldOffset(Offset = "0x78")]
    public float MaxBodyTextWidth;
    [Token(Token = "0x400A0FC")]
    [FieldOffset(Offset = "0x7C")]
    private float mBaseWidth;
    [Token(Token = "0x400A0FD")]
    [FieldOffset(Offset = "0x80")]
    private float mStartTime;
    [Token(Token = "0x400A0FE")]
    [FieldOffset(Offset = "0x84")]
    private bool mTextNeedsUpdate;
    [Token(Token = "0x400A0FF")]
    [FieldOffset(Offset = "0x88")]
    private string mTextQueue;
    [Token(Token = "0x400A100")]
    [FieldOffset(Offset = "0x4")]
    private static Regex regEndTag;
    [Token(Token = "0x400A101")]
    [FieldOffset(Offset = "0x8")]
    private static Regex regColor;
    [Token(Token = "0x400A102")]
    [FieldOffset(Offset = "0x8C")]
    private bool mFadingOut;
    [Token(Token = "0x400A103")]
    [FieldOffset(Offset = "0x8D")]
    private bool mShouldOpen;

    [Token(Token = "0x1700156E")]
    public PortraitSet PortraitSet
    {
      [Token(Token = "0x6009A37"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] set
      {
      }
      [Token(Token = "0x6009A38"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (PortraitSet) null;
      }
    }

    [Token(Token = "0x6009A39")]
    [Address(RVA = "0x5E63F0", Offset = "0x5E51F0", VA = "0x105E63F0")]
    public static EventTelopBubble Find(string id) => (EventTelopBubble) null;

    [Token(Token = "0x6009A3A")]
    [Address(RVA = "0x5E6210", Offset = "0x5E5010", VA = "0x105E6210")]
    public static void DiscardAll()
    {
    }

    [Token(Token = "0x6009A3B")]
    [Address(RVA = "0x5E7060", Offset = "0x5E5E60", VA = "0x105E7060")]
    private void UpdatePortrait()
    {
    }

    [Token(Token = "0x6009A3C")]
    [Address(RVA = "0x5E5FE0", Offset = "0x5E4DE0", VA = "0x105E5FE0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009A3D")]
    [Address(RVA = "0x5E67A0", Offset = "0x5E55A0", VA = "0x105E67A0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x1700156F")]
    public bool IsPrinting
    {
      [Token(Token = "0x6009A3E"), Address(RVA = "0x5E7D50", Offset = "0x5E6B50", VA = "0x105E7D50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009A3F")]
    [Address(RVA = "0x5E6DB0", Offset = "0x5E5BB0", VA = "0x105E6DB0")]
    public void Skip()
    {
    }

    [Token(Token = "0x6009A40")]
    [Address(RVA = "0x5E5D20", Offset = "0x5E4B20", VA = "0x105E5D20")]
    public void AdjustWidth(string bodyText)
    {
    }

    [Token(Token = "0x6009A41")]
    [Address(RVA = "0x5E6CF0", Offset = "0x5E5AF0", VA = "0x105E6CF0")]
    public void SetName(string name)
    {
    }

    [Token(Token = "0x6009A42")]
    [Address(RVA = "0x5E6E40", Offset = "0x5E5C40", VA = "0x105E6E40")]
    private static EventTelopBubble.Element[] SplitTags(string s)
    {
      return (EventTelopBubble.Element[]) null;
    }

    [Token(Token = "0x6009A43")]
    [Address(RVA = "0x5E6870", Offset = "0x5E5670", VA = "0x105E6870")]
    private void Parse(
      EventTelopBubble.Element[] c,
      ref int n,
      string end,
      EventTelopBubble.Ctx ctx)
    {
    }

    [Token(Token = "0x6009A44")]
    [Address(RVA = "0x5E6AD0", Offset = "0x5E58D0", VA = "0x105E6AD0")]
    private void PushCharacters(string s, EventTelopBubble.Ctx ctx)
    {
    }

    [Token(Token = "0x6009A45")]
    [Address(RVA = "0x5E6500", Offset = "0x5E5300", VA = "0x105E6500")]
    private void FlushText()
    {
    }

    [Token(Token = "0x6009A46")]
    [Address(RVA = "0x5E6C10", Offset = "0x5E5A10", VA = "0x105E6C10")]
    public void SetBody(string text)
    {
    }

    [Token(Token = "0x6009A47")]
    [Address(RVA = "0x5E6810", Offset = "0x5E5610", VA = "0x105E6810")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009A48")]
    [Address(RVA = "0x5E7050", Offset = "0x5E5E50", VA = "0x105E7050")]
    private void Start()
    {
    }

    [Token(Token = "0x6009A49")]
    [Address(RVA = "0x5E6130", Offset = "0x5E4F30", VA = "0x105E6130")]
    private void BeginFadeOut()
    {
    }

    [Token(Token = "0x17001570")]
    public bool Finished
    {
      [Token(Token = "0x6009A4A"), Address(RVA = "0x5E7D30", Offset = "0x5E6B30", VA = "0x105E7D30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009A4B")]
    [Address(RVA = "0x5E6830", Offset = "0x5E5630", VA = "0x105E6830")]
    public void Open()
    {
    }

    [Token(Token = "0x6009A4C")]
    [Address(RVA = "0x5E61D0", Offset = "0x5E4FD0", VA = "0x105E61D0")]
    public void Close()
    {
    }

    [Token(Token = "0x6009A4D")]
    [Address(RVA = "0x5E6D70", Offset = "0x5E5B70", VA = "0x105E6D70")]
    private void SetVisibility(bool open)
    {
    }

    [Token(Token = "0x6009A4E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Forward()
    {
    }

    [Token(Token = "0x6009A4F")]
    [Address(RVA = "0x5E74B0", Offset = "0x5E62B0", VA = "0x105E74B0")]
    private void UpdateText()
    {
    }

    [Token(Token = "0x6009A50")]
    [Address(RVA = "0x5E7430", Offset = "0x5E6230", VA = "0x105E7430")]
    private void UpdateStateBool()
    {
    }

    [Token(Token = "0x6009A51")]
    [Address(RVA = "0x5E7900", Offset = "0x5E6700", VA = "0x105E7900")]
    private void Update()
    {
    }

    [Token(Token = "0x6009A52")]
    [Address(RVA = "0x5E7C70", Offset = "0x5E6A70", VA = "0x105E7C70")]
    public EventTelopBubble()
    {
    }

    [Token(Token = "0x6009A53")]
    [Address(RVA = "0x5E7B50", Offset = "0x5E6950", VA = "0x105E7B50")]
    static EventTelopBubble()
    {
    }

    [Token(Token = "0x20023A6")]
    private struct Character
    {
      [Token(Token = "0x400A104")]
      [FieldOffset(Offset = "0x0")]
      public char Code;
      [Token(Token = "0x400A105")]
      [FieldOffset(Offset = "0x4")]
      public Color32 Color;
      [Token(Token = "0x400A106")]
      [FieldOffset(Offset = "0x8")]
      public float Interval;
      [Token(Token = "0x400A107")]
      [FieldOffset(Offset = "0xC")]
      public float TimeOffset;

      [Token(Token = "0x6009A54")]
      [Address(RVA = "0x5A8DA0", Offset = "0x5A7BA0", VA = "0x105A8DA0")]
      public Character(char code, Color32 color, float interval, float timeOffset)
      {
      }
    }

    [Token(Token = "0x20023A7")]
    private class Element
    {
      [Token(Token = "0x400A108")]
      [FieldOffset(Offset = "0x8")]
      public string Tag;
      [Token(Token = "0x400A109")]
      [FieldOffset(Offset = "0xC")]
      public string Value;

      [Token(Token = "0x6009A55")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Element()
      {
      }
    }

    [Token(Token = "0x20023A8")]
    private struct Ctx
    {
      [Token(Token = "0x400A10A")]
      [FieldOffset(Offset = "0x0")]
      public Color32 Color;
      [Token(Token = "0x400A10B")]
      [FieldOffset(Offset = "0x4")]
      public float Interval;
    }
  }
}
