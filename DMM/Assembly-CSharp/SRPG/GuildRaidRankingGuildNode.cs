// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRankingGuildNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002598")]
  public class GuildRaidRankingGuildNode : ContentNode
  {
    [Token(Token = "0x400AE66")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public GameObject bindObject;
    [Token(Token = "0x400AE67")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public GameObject EmptyObject;

    [Token(Token = "0x600A6FC")]
    [Address(RVA = "0x687C10", Offset = "0x686A10", VA = "0x10687C10")]
    public void Setup(GuildRaidRanking guildRaidRanking)
    {
    }

    [Token(Token = "0x600A6FD")]
    [Address(RVA = "0x687B40", Offset = "0x686940", VA = "0x10687B40")]
    public void Empty(bool is_enmpty)
    {
    }

    [Token(Token = "0x600A6FE")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public GuildRaidRankingGuildNode()
    {
    }
  }
}
