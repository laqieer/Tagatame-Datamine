// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingUnitListCampaign
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002543")]
  public class GuildTrainingUnitListCampaign : MonoBehaviour
  {
    [Token(Token = "0x400AACF")]
    private const float CHANGE_INTERBAL = 1f;
    [Token(Token = "0x400AAD0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mCampaignDrop;
    [Token(Token = "0x400AAD1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mCampaignTime;
    [Token(Token = "0x400AAD2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mObjLimited;
    [Token(Token = "0x400AAD3")]
    [FieldOffset(Offset = "0x18")]
    private GuildTrainingWindow mGuildTrainingWindow;
    [Token(Token = "0x400AAD4")]
    [FieldOffset(Offset = "0x1C")]
    private List<GameObject> mTargets;
    [Token(Token = "0x400AAD5")]
    [FieldOffset(Offset = "0x20")]
    private DateTime mLastUpdateDate;
    [Token(Token = "0x400AAD6")]
    [FieldOffset(Offset = "0x28")]
    private int mLastSelectIndex;

    [Token(Token = "0x600A44A")]
    [Address(RVA = "0x662780", Offset = "0x661580", VA = "0x10662780")]
    public void Setup(bool is_drop, bool is_time, bool is_limited)
    {
    }

    [Token(Token = "0x600A44B")]
    [Address(RVA = "0x662A10", Offset = "0x661810", VA = "0x10662A10")]
    private void UpdateViewCampaignIcon()
    {
    }

    [Token(Token = "0x600A44C")]
    [Address(RVA = "0x662B30", Offset = "0x661930", VA = "0x10662B30")]
    private void Update()
    {
    }

    [Token(Token = "0x600A44D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildTrainingUnitListCampaign()
    {
    }
  }
}
