// Decompiled with JetBrains decompiler
// Type: SRPG.DeathSentenceIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022F0")]
  [AddComponentMenu("UI/DeathSentenceIcon")]
  public class DeathSentenceIcon : MonoBehaviour
  {
    [Token(Token = "0x4009BB9")]
    [FieldOffset(Offset = "0xC")]
    public GameObject DeathIconPrefab;
    [Token(Token = "0x4009BBA")]
    [FieldOffset(Offset = "0x10")]
    private Text mCountDownText;
    [Token(Token = "0x4009BBB")]
    [FieldOffset(Offset = "0x14")]
    private GameObject mDeathIcon;
    [Token(Token = "0x4009BBC")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsDeathSentenceCountDownPlaying;

    [Token(Token = "0x600962E")]
    [Address(RVA = "0x58F850", Offset = "0x58E650", VA = "0x1058F850")]
    public void Init(Unit parent)
    {
    }

    [Token(Token = "0x600962F")]
    [Address(RVA = "0x58FA00", Offset = "0x58E800", VA = "0x1058FA00")]
    public void Open()
    {
    }

    [Token(Token = "0x6009630")]
    [Address(RVA = "0x58F680", Offset = "0x58E480", VA = "0x1058F680")]
    public void Close()
    {
    }

    [Token(Token = "0x6009631")]
    [Address(RVA = "0x58FA90", Offset = "0x58E890", VA = "0x1058FA90")]
    public void UpdateCountDown(int currentCount)
    {
    }

    [Token(Token = "0x170014F8")]
    public bool IsDeathSentenceCountDownPlaying
    {
      [Token(Token = "0x6009632"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009633"), Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")] set
      {
      }
    }

    [Token(Token = "0x6009634")]
    [Address(RVA = "0x58F710", Offset = "0x58E510", VA = "0x1058F710")]
    private IEnumerator CountdownInternal(int currentCount, float LifeSeconds)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6009635")]
    [Address(RVA = "0x58F790", Offset = "0x58E590", VA = "0x1058F790")]
    public void Countdown(int currentCount, float LifeSeconds = 0.0f)
    {
    }

    [Token(Token = "0x6009636")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DeathSentenceIcon()
    {
    }
  }
}
