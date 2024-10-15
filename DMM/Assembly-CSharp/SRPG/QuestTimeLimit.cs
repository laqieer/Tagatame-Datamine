// Decompiled with JetBrains decompiler
// Type: SRPG.QuestTimeLimit
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
  [Token(Token = "0x20010C5")]
  [AddComponentMenu("Common/QuestTimeLimit")]
  public class QuestTimeLimit : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x4003C76")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Body;
    [Token(Token = "0x4003C77")]
    [FieldOffset(Offset = "0x10")]
    public GameObject RankingTermItem;
    [Token(Token = "0x4003C78")]
    [FieldOffset(Offset = "0x14")]
    public Text Timer;
    [Token(Token = "0x4003C79")]
    [FieldOffset(Offset = "0x18")]
    public Text TimerRanking;
    [Token(Token = "0x4003C7A")]
    [FieldOffset(Offset = "0x1C")]
    public bool IsTTMMSS;
    [Token(Token = "0x4003C7B")]
    [FieldOffset(Offset = "0x20")]
    private long mEndTime;
    [Token(Token = "0x4003C7C")]
    [FieldOffset(Offset = "0x28")]
    private float mRefreshInterval;
    [Token(Token = "0x4003C7D")]
    [FieldOffset(Offset = "0x2C")]
    private bool mIsRankingTerm;
    [Token(Token = "0x4003C7E")]
    [FieldOffset(Offset = "0x30")]
    public QuestTimeLimit.OnTimeLimit mOnTimeLimit;
    [Token(Token = "0x4003C7F")]
    [FieldOffset(Offset = "0x38")]
    private TimeSpan mCurrentSpan;
    [Token(Token = "0x4003C80")]
    [FieldOffset(Offset = "0x40")]
    private bool isSetEnd;

    [Token(Token = "0x6004702")]
    [Address(RVA = "0x11E68C0", Offset = "0x11E56C0", VA = "0x111E68C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6004703")]
    [Address(RVA = "0x11E6FF0", Offset = "0x11E5DF0", VA = "0x111E6FF0")]
    private void Start()
    {
    }

    [Token(Token = "0x6004704")]
    [Address(RVA = "0x11E7290", Offset = "0x11E6090", VA = "0x111E7290")]
    private void Update()
    {
    }

    [Token(Token = "0x6004705")]
    [Address(RVA = "0x11E6910", Offset = "0x11E5710", VA = "0x111E6910")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6004706")]
    [Address(RVA = "0x11E7010", Offset = "0x11E5E10", VA = "0x111E7010", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6004707")]
    [Address(RVA = "0x11E6FC0", Offset = "0x11E5DC0", VA = "0x111E6FC0")]
    public void SetEnd()
    {
    }

    [Token(Token = "0x6004708")]
    [Address(RVA = "0x4E6350", Offset = "0x4E5150", VA = "0x104E6350")]
    public QuestTimeLimit()
    {
    }

    [Token(Token = "0x20010C6")]
    public delegate void OnTimeLimit();
  }
}
