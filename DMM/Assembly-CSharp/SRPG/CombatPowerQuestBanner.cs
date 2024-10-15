// Decompiled with JetBrains decompiler
// Type: SRPG.CombatPowerQuestBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021AE")]
  [AddComponentMenu("UI/CombatPowerQuestBanner")]
  public class CombatPowerQuestBanner : BaseIcon
  {
    [Token(Token = "0x400937F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject CombatPowerLock;
    [Token(Token = "0x4009380")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private QuestTimeLimit QuestTimer;
    [Token(Token = "0x4009381")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ChallengeCountLock;
    [Token(Token = "0x4009382")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Counter;
    [Token(Token = "0x4009383")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text CounterText;
    [Token(Token = "0x4009384")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text CounterLimitText;
    [Token(Token = "0x4009385")]
    [FieldOffset(Offset = "0x24")]
    private bool mHideChallengeCounter;

    [Token(Token = "0x6008DCF")]
    [Address(RVA = "0x512B50", Offset = "0x511950", VA = "0x10512B50", Slot = "12")]
    public override void UpdateValue()
    {
    }

    [Token(Token = "0x6008DD0")]
    [Address(RVA = "0x2A5AD0", Offset = "0x2A48D0", VA = "0x102A5AD0")]
    public void SetHideChallengeCounter(bool hide)
    {
    }

    [Token(Token = "0x6008DD1")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public CombatPowerQuestBanner()
    {
    }
  }
}
