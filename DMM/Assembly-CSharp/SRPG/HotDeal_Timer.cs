// Decompiled with JetBrains decompiler
// Type: SRPG.HotDeal_Timer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002642")]
  [AddComponentMenu("UI/HotDeal/HotDeal_Timer")]
  public class HotDeal_Timer : MonoBehaviour
  {
    [Token(Token = "0x400B2B9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text m_timer;
    [Token(Token = "0x400B2BA")]
    [FieldOffset(Offset = "0x10")]
    private DateTime m_TargetTime;
    [Token(Token = "0x400B2BB")]
    [FieldOffset(Offset = "0x18")]
    private string m_SysTimerFromat;
    [Token(Token = "0x400B2BC")]
    [FieldOffset(Offset = "0x1C")]
    private string m_SysTimerEnd;

    [Token(Token = "0x600AAC6")]
    [Address(RVA = "0x6E2040", Offset = "0x6E0E40", VA = "0x106E2040")]
    private void Start()
    {
    }

    [Token(Token = "0x600AAC7")]
    [Address(RVA = "0x6E2320", Offset = "0x6E1120", VA = "0x106E2320")]
    private void Update()
    {
    }

    [Token(Token = "0x600AAC8")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600AAC9")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AACA")]
    [Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")]
    public void SetUp(DateTime _endTime)
    {
    }

    [Token(Token = "0x600AACB")]
    [Address(RVA = "0x6E1FB0", Offset = "0x6E0DB0", VA = "0x106E1FB0")]
    public bool IsTimeOver() => new bool();

    [Token(Token = "0x600AACC")]
    [Address(RVA = "0x6E20D0", Offset = "0x6E0ED0", VA = "0x106E20D0")]
    public void TimerUpdate()
    {
    }

    [Token(Token = "0x600AACD")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public HotDeal_Timer()
    {
    }
  }
}
