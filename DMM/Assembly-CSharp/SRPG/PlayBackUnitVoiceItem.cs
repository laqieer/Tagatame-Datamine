// Decompiled with JetBrains decompiler
// Type: SRPG.PlayBackUnitVoiceItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027F5")]
  [AddComponentMenu("UI/PlayBackUnitVoiceItem")]
  public class PlayBackUnitVoiceItem : MonoBehaviour
  {
    [Token(Token = "0x400BE32")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text VoiceName;
    [Token(Token = "0x400BE33")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle PlayingBadge;
    [Token(Token = "0x400BE34")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject LockIcon;
    [Token(Token = "0x400BE35")]
    [FieldOffset(Offset = "0x18")]
    private UnitData.UnitVoiceCueInfo mUnitVoiceCueInfo;
    [Token(Token = "0x400BE36")]
    [FieldOffset(Offset = "0x1C")]
    private string m_CueName;
    [Token(Token = "0x400BE37")]
    [FieldOffset(Offset = "0x20")]
    private string m_ButtonName;
    [Token(Token = "0x400BE38")]
    [FieldOffset(Offset = "0x24")]
    private bool m_IsLocked;
    [Token(Token = "0x400BE39")]
    [FieldOffset(Offset = "0x28")]
    public PlayBackUnitVoiceItem.TapEvent OnTabEvent;

    [Token(Token = "0x170018B9")]
    public string CueName
    {
      [Token(Token = "0x600B468"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170018BA")]
    public bool IsLocked
    {
      [Token(Token = "0x600B469"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B46A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B46B")]
    [Address(RVA = "0x7AED70", Offset = "0x7ADB70", VA = "0x107AED70")]
    public void SetUp(UnitData.UnitVoiceCueInfo UnitVoiceCueInfo)
    {
    }

    [Token(Token = "0x600B46C")]
    [Address(RVA = "0x7AECB0", Offset = "0x7ADAB0", VA = "0x107AECB0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B46D")]
    [Address(RVA = "0x7AECE0", Offset = "0x7ADAE0", VA = "0x107AECE0")]
    public void SetPlayingBadge(bool value)
    {
    }

    [Token(Token = "0x600B46E")]
    [Address(RVA = "0x7AEBD0", Offset = "0x7AD9D0", VA = "0x107AEBD0")]
    public string GetUnlockConditionsText() => (string) null;

    [Token(Token = "0x600B46F")]
    [Address(RVA = "0x7AEBF0", Offset = "0x7AD9F0", VA = "0x107AEBF0")]
    public void Lock()
    {
    }

    [Token(Token = "0x600B470")]
    [Address(RVA = "0x7AEDC0", Offset = "0x7ADBC0", VA = "0x107AEDC0")]
    public void Unlock()
    {
    }

    [Token(Token = "0x600B471")]
    [Address(RVA = "0x7AEE80", Offset = "0x7ADC80", VA = "0x107AEE80")]
    public PlayBackUnitVoiceItem()
    {
    }

    [Token(Token = "0x20027F6")]
    public delegate void TapEvent();
  }
}
