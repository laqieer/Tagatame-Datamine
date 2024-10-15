// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRewardList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002599")]
  [AddComponentMenu("UI/GuildRaidRewardList")]
  public class GuildRaidRewardList : SRPG_ListBase
  {
    [Token(Token = "0x400AE68")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RaidRewardListItem mListItem;

    [Token(Token = "0x600A6FF")]
    [Address(RVA = "0x68C5C0", Offset = "0x68B3C0", VA = "0x1068C5C0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600A700")]
    [Address(RVA = "0x68C1E0", Offset = "0x68AFE0", VA = "0x1068C1E0")]
    private void CreateList(RaidRewardListItem ListItem, List<GuildRaidReward> rewards)
    {
    }

    [Token(Token = "0x600A701")]
    [Address(RVA = "0x68C420", Offset = "0x68B220", VA = "0x1068C420")]
    private void GetEmblem(GameObject obj, string name)
    {
    }

    [Token(Token = "0x600A702")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public GuildRaidRewardList()
    {
    }
  }
}
