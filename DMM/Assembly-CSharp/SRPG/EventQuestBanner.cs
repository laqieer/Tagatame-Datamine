// Decompiled with JetBrains decompiler
// Type: SRPG.EventQuestBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002373")]
  [AddComponentMenu("UI/EventQuestBanner")]
  public class EventQuestBanner : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x4009F5A")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Lock;
    [Token(Token = "0x4009F5B")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Counter;
    [Token(Token = "0x4009F5C")]
    [FieldOffset(Offset = "0x14")]
    public Text CounterText;
    [Token(Token = "0x4009F5D")]
    [FieldOffset(Offset = "0x18")]
    public Text CounterLimitText;
    [Token(Token = "0x4009F5E")]
    [FieldOffset(Offset = "0x1C")]
    private bool m_HideChallengeCounter;

    [Token(Token = "0x600991A")]
    [Address(RVA = "0x5D0840", Offset = "0x5CF640", VA = "0x105D0840")]
    private void Start()
    {
    }

    [Token(Token = "0x600991B")]
    [Address(RVA = "0x5D0850", Offset = "0x5CF650", VA = "0x105D0850", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600991C")]
    [Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")]
    public void SetHideChallengeCounter(bool hide)
    {
    }

    [Token(Token = "0x600991D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EventQuestBanner()
    {
    }
  }
}
