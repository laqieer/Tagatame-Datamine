// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaRankingList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FDB")]
  [AddComponentMenu("UI/ArenaRankingList")]
  public class ArenaRankingList : SRPG_ListBase
  {
    [Token(Token = "0x400870F")]
    [FieldOffset(Offset = "0x20")]
    public ReqBtlColoRanking.RankingTypes RankingType;
    [Token(Token = "0x4008710")]
    [FieldOffset(Offset = "0x24")]
    public ListItemEvents ListItem_Normal;
    [Token(Token = "0x4008711")]
    [FieldOffset(Offset = "0x28")]
    public ListItemEvents ListItem_Self;
    [Token(Token = "0x4008712")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject OwnRankingInfo;
    [Token(Token = "0x4008713")]
    [FieldOffset(Offset = "0x30")]
    public GameObject DetailWindow;
    [Token(Token = "0x4008714")]
    [FieldOffset(Offset = "0x34")]
    private ArenaPlayer arenaPlayerOwner;

    [Token(Token = "0x6008330")]
    [Address(RVA = "0x43A620", Offset = "0x439420", VA = "0x1043A620", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x6008331")]
    [Address(RVA = "0x43A090", Offset = "0x438E90", VA = "0x1043A090")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008332")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x6008333")]
    [Address(RVA = "0x439F90", Offset = "0x438D90", VA = "0x10439F90")]
    private void OnItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x6008334")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public ArenaRankingList()
    {
    }
  }
}
