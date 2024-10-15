// Decompiled with JetBrains decompiler
// Type: SRPG.EventDialogBubbleCustom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200236A")]
  [AddComponentMenu("UI/EventDialogBubbleCustom")]
  public class EventDialogBubbleCustom : MonoBehaviour
  {
    [Token(Token = "0x4009EFB")]
    [FieldOffset(Offset = "0x0")]
    public static List<EventDialogBubbleCustom> Instances;
    [Token(Token = "0x4009EFC")]
    public const float TopMargin = 30f;
    [Token(Token = "0x4009EFD")]
    public const float BottomMargin = 20f;
    [Token(Token = "0x4009EFE")]
    public const float LeftMargin = 20f;
    [Token(Token = "0x4009EFF")]
    public const float RightMargin = 20f;
    [Token(Token = "0x4009F00")]
    [FieldOffset(Offset = "0xC")]
    public UnityEngine.UI.Text NameText;
    [Token(Token = "0x4009F01")]
    [FieldOffset(Offset = "0x10")]
    public UnityEngine.UI.Text BodyText;
    [Token(Token = "0x4009F02")]
    [FieldOffset(Offset = "0x14")]
    public string VisibilityBoolName;
    [Token(Token = "0x4009F03")]
    [FieldOffset(Offset = "0x18")]
    public Animator BubbleAnimator;
    [Token(Token = "0x4009F04")]
    [FieldOffset(Offset = "0x1C")]
    public string OpenedStateName;
    [Token(Token = "0x4009F05")]
    [FieldOffset(Offset = "0x20")]
    public string ClosedStateName;
    [Token(Token = "0x4009F06")]
    [FieldOffset(Offset = "0x24")]
    [NonSerialized]
    public string BubbleID;
    [Token(Token = "0x4009F07")]
    [FieldOffset(Offset = "0x28")]
    private bool mCloseAndDestroy;
    [Token(Token = "0x4009F0A")]
    [FieldOffset(Offset = "0x34")]
    private MySound.Voice mVoice;
    [Token(Token = "0x4009F0B")]
    [FieldOffset(Offset = "0x38")]
    private readonly float VoiceFadeOutSec;
    [Token(Token = "0x4009F0C")]
    [FieldOffset(Offset = "0x3C")]
    private bool mSkipFadeOut;
    [Token(Token = "0x4009F0D")]
    [FieldOffset(Offset = "0x40")]
    public float FadeInTime;
    [Token(Token = "0x4009F0E")]
    [FieldOffset(Offset = "0x44")]
    public float FadeOutTime;
    [Token(Token = "0x4009F0F")]
    [FieldOffset(Offset = "0x48")]
    public float FadeOutInterval;
    [Token(Token = "0x4009F10")]
    [FieldOffset(Offset = "0x4C")]
    private EventDialogBubbleCustom.Character[] mCharacters;
    [Token(Token = "0x4009F11")]
    [FieldOffset(Offset = "0x50")]
    private int mNumCharacters;
    [Token(Token = "0x4009F12")]
    [FieldOffset(Offset = "0x54")]
    public float NewLineInterval;
    [Token(Token = "0x4009F13")]
    [FieldOffset(Offset = "0x58")]
    [NonSerialized]
    public EventAction_Dialog.TextSpeedTypes TextSpeed;
    [Token(Token = "0x4009F14")]
    [FieldOffset(Offset = "0x5C")]
    public bool AutoExpandWidth;
    [Token(Token = "0x4009F15")]
    [FieldOffset(Offset = "0x60")]
    public float MaxBodyTextWidth;
    [Token(Token = "0x4009F16")]
    [FieldOffset(Offset = "0x64")]
    private float mBaseWidth;
    [Token(Token = "0x4009F17")]
    [FieldOffset(Offset = "0x68")]
    private float mStartTime;
    [Token(Token = "0x4009F18")]
    [FieldOffset(Offset = "0x6C")]
    private bool mTextNeedsUpdate;
    [Token(Token = "0x4009F19")]
    [FieldOffset(Offset = "0x70")]
    private string mTextQueue;
    [Token(Token = "0x4009F1A")]
    [FieldOffset(Offset = "0x4")]
    private static Regex regEndTag;
    [Token(Token = "0x4009F1B")]
    [FieldOffset(Offset = "0x8")]
    private static Regex regColor;
    [Token(Token = "0x4009F1C")]
    private const string REPLACE_PLAYER_NAME = "REPLACE_PLAYER_NAME";
    [Token(Token = "0x4009F1D")]
    [FieldOffset(Offset = "0x74")]
    private bool mFadingOut;
    [Token(Token = "0x4009F1E")]
    [FieldOffset(Offset = "0x75")]
    private bool mShouldOpen;
    [Token(Token = "0x4009F1F")]
    [FieldOffset(Offset = "0x78")]
    private EventDialogBubbleCustom.Anchors mAnchor;

    [Token(Token = "0x17001556")]
    public string VoiceSheetName
    {
      [Token(Token = "0x60098D1"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098D2"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] set
      {
      }
    }

    [Token(Token = "0x17001557")]
    public string VoiceCueName
    {
      [Token(Token = "0x60098D3"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098D4"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] set
      {
      }
    }

    [Token(Token = "0x60098D5")]
    [Address(RVA = "0x5B3CC0", Offset = "0x5B2AC0", VA = "0x105B3CC0")]
    public static EventDialogBubbleCustom Find(string id) => (EventDialogBubbleCustom) null;

    [Token(Token = "0x60098D6")]
    [Address(RVA = "0x5B3C60", Offset = "0x5B2A60", VA = "0x105B3C60")]
    public static EventDialogBubbleCustom FindHead() => (EventDialogBubbleCustom) null;

    [Token(Token = "0x60098D7")]
    [Address(RVA = "0x5B3A30", Offset = "0x5B2830", VA = "0x105B3A30")]
    public static void DiscardAll()
    {
    }

    [Token(Token = "0x17001558")]
    public bool IsVoicePlaying
    {
      [Token(Token = "0x60098D8"), Address(RVA = "0x5B5990", Offset = "0x5B4790", VA = "0x105B5990")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60098D9")]
    [Address(RVA = "0x5B3730", Offset = "0x5B2530", VA = "0x105B3730")]
    private void Awake()
    {
    }

    [Token(Token = "0x60098DA")]
    [Address(RVA = "0x5B4360", Offset = "0x5B3160", VA = "0x105B4360")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60098DB")]
    [Address(RVA = "0x5B3C10", Offset = "0x5B2A10", VA = "0x105B3C10")]
    private void FadeOutVoice()
    {
    }

    [Token(Token = "0x60098DC")]
    [Address(RVA = "0x5B5000", Offset = "0x5B3E00", VA = "0x105B5000")]
    public void StopVoice()
    {
    }

    [Token(Token = "0x17001559")]
    public bool IsPrinting
    {
      [Token(Token = "0x60098DD"), Address(RVA = "0x5B5970", Offset = "0x5B4770", VA = "0x105B5970")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60098DE")]
    [Address(RVA = "0x5B4270", Offset = "0x5B3070", VA = "0x105B4270")]
    private void OnBackLogButtonClicked()
    {
    }

    [Token(Token = "0x60098DF")]
    [Address(RVA = "0x5B4D20", Offset = "0x5B3B20", VA = "0x105B4D20")]
    public void Skip()
    {
    }

    [Token(Token = "0x60098E0")]
    [Address(RVA = "0x5B3470", Offset = "0x5B2270", VA = "0x105B3470")]
    public void AdjustWidth(string bodyText)
    {
    }

    [Token(Token = "0x60098E1")]
    [Address(RVA = "0x5B4C40", Offset = "0x5B3A40", VA = "0x105B4C40")]
    public void SetName(string name)
    {
    }

    [Token(Token = "0x1700155A")]
    public string Name
    {
      [Token(Token = "0x60098E2"), Address(RVA = "0x5B59C0", Offset = "0x5B47C0", VA = "0x105B59C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700155B")]
    public string Text
    {
      [Token(Token = "0x60098E3"), Address(RVA = "0x5B5A50", Offset = "0x5B4850", VA = "0x105B5A50")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60098E4")]
    [Address(RVA = "0x5B4DE0", Offset = "0x5B3BE0", VA = "0x105B4DE0")]
    private static EventDialogBubbleCustom.Element[] SplitTags(string s)
    {
      return (EventDialogBubbleCustom.Element[]) null;
    }

    [Token(Token = "0x60098E5")]
    [Address(RVA = "0x5B4690", Offset = "0x5B3490", VA = "0x105B4690")]
    private void Parse(
      EventDialogBubbleCustom.Element[] c,
      ref int n,
      string end,
      EventDialogBubbleCustom.Ctx ctx)
    {
    }

    [Token(Token = "0x60098E6")]
    [Address(RVA = "0x5B48F0", Offset = "0x5B36F0", VA = "0x105B48F0")]
    private void PushCharacters(string s, EventDialogBubbleCustom.Ctx ctx)
    {
    }

    [Token(Token = "0x60098E7")]
    [Address(RVA = "0x5B4A20", Offset = "0x5B3820", VA = "0x105B4A20")]
    public string ReplaceText(string text, bool is_two_steps = false) => (string) null;

    [Token(Token = "0x60098E8")]
    [Address(RVA = "0x5B3DD0", Offset = "0x5B2BD0", VA = "0x105B3DD0")]
    private void FlushText()
    {
    }

    [Token(Token = "0x60098E9")]
    [Address(RVA = "0x5B4B70", Offset = "0x5B3970", VA = "0x105B4B70")]
    public void SetBody(string text)
    {
    }

    [Token(Token = "0x60098EA")]
    [Address(RVA = "0x5B44A0", Offset = "0x5B32A0", VA = "0x105B44A0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60098EB")]
    [Address(RVA = "0x5B4FF0", Offset = "0x5B3DF0", VA = "0x105B4FF0")]
    private void Start()
    {
    }

    [Token(Token = "0x60098EC")]
    [Address(RVA = "0x5B3960", Offset = "0x5B2760", VA = "0x105B3960")]
    private void BeginFadeOut()
    {
    }

    [Token(Token = "0x1700155C")]
    public bool Finished
    {
      [Token(Token = "0x60098ED"), Address(RVA = "0x5B5950", Offset = "0x5B4750", VA = "0x105B5950")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60098EE")]
    [Address(RVA = "0x5B44C0", Offset = "0x5B32C0", VA = "0x105B44C0")]
    public void Open()
    {
    }

    [Token(Token = "0x60098EF")]
    [Address(RVA = "0x5B39F0", Offset = "0x5B27F0", VA = "0x105B39F0")]
    public void Close()
    {
    }

    [Token(Token = "0x60098F0")]
    [Address(RVA = "0x5B4CE0", Offset = "0x5B3AE0", VA = "0x105B4CE0")]
    private void SetVisibility(bool open)
    {
    }

    [Token(Token = "0x60098F1")]
    [Address(RVA = "0x5B4230", Offset = "0x5B3030", VA = "0x105B4230")]
    public void Forward()
    {
    }

    [Token(Token = "0x60098F2")]
    [Address(RVA = "0x5B50C0", Offset = "0x5B3EC0", VA = "0x105B50C0")]
    private void UpdateText()
    {
    }

    [Token(Token = "0x60098F3")]
    [Address(RVA = "0x5B5040", Offset = "0x5B3E40", VA = "0x105B5040")]
    private void UpdateStateBool()
    {
    }

    [Token(Token = "0x60098F4")]
    [Address(RVA = "0x5B5530", Offset = "0x5B4330", VA = "0x105B5530")]
    private void Update()
    {
    }

    [Token(Token = "0x1700155D")]
    public EventDialogBubbleCustom.Anchors Anchor
    {
      [Token(Token = "0x60098F5"), Address(RVA = "0x5B5AE0", Offset = "0x5B48E0", VA = "0x105B5AE0")] set
      {
      }
      [Token(Token = "0x60098F6"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return new EventDialogBubbleCustom.Anchors();
      }
    }

    [Token(Token = "0x60098F7")]
    [Address(RVA = "0x5B5890", Offset = "0x5B4690", VA = "0x105B5890")]
    public EventDialogBubbleCustom()
    {
    }

    [Token(Token = "0x60098F8")]
    [Address(RVA = "0x5B5770", Offset = "0x5B4570", VA = "0x105B5770")]
    static EventDialogBubbleCustom()
    {
    }

    [Token(Token = "0x200236B")]
    private struct Character
    {
      [Token(Token = "0x4009F20")]
      [FieldOffset(Offset = "0x0")]
      public char Code;
      [Token(Token = "0x4009F21")]
      [FieldOffset(Offset = "0x4")]
      public Color32 Color;
      [Token(Token = "0x4009F22")]
      [FieldOffset(Offset = "0x8")]
      public float Interval;
      [Token(Token = "0x4009F23")]
      [FieldOffset(Offset = "0xC")]
      public float TimeOffset;

      [Token(Token = "0x60098F9")]
      [Address(RVA = "0x5A8DA0", Offset = "0x5A7BA0", VA = "0x105A8DA0")]
      public Character(char code, Color32 color, float interval, float timeOffset)
      {
      }
    }

    [Token(Token = "0x200236C")]
    private class Element
    {
      [Token(Token = "0x4009F24")]
      [FieldOffset(Offset = "0x8")]
      public string Tag;
      [Token(Token = "0x4009F25")]
      [FieldOffset(Offset = "0xC")]
      public string Value;

      [Token(Token = "0x60098FA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Element()
      {
      }
    }

    [Token(Token = "0x200236D")]
    private struct Ctx
    {
      [Token(Token = "0x4009F26")]
      [FieldOffset(Offset = "0x0")]
      public Color32 Color;
      [Token(Token = "0x4009F27")]
      [FieldOffset(Offset = "0x4")]
      public float Interval;
    }

    [Token(Token = "0x200236E")]
    public enum Anchors
    {
      [Token(Token = "0x4009F29")] None,
      [Token(Token = "0x4009F2A")] TopLeft,
      [Token(Token = "0x4009F2B")] TopCenter,
      [Token(Token = "0x4009F2C")] TopRight,
      [Token(Token = "0x4009F2D")] MiddleLeft,
      [Token(Token = "0x4009F2E")] Center,
      [Token(Token = "0x4009F2F")] MiddleRight,
      [Token(Token = "0x4009F30")] BottomLeft,
      [Token(Token = "0x4009F31")] BottomCenter,
      [Token(Token = "0x4009F32")] BottomRight,
    }
  }
}
