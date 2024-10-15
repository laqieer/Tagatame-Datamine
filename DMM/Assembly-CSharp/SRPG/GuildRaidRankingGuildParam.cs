// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRankingGuildParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002597")]
  public class GuildRaidRankingGuildParam : ContentSource.Param
  {
    [Token(Token = "0x400AE63")]
    [FieldOffset(Offset = "0x10")]
    public GuildRaidRanking mGuildRaidRanking;
    [Token(Token = "0x400AE64")]
    [FieldOffset(Offset = "0x14")]
    public bool IsEmpty;
    [Token(Token = "0x400AE65")]
    [FieldOffset(Offset = "0x18")]
    private GuildRaidRankingGuildNode mNode;

    [Token(Token = "0x600A6F8")]
    [Address(RVA = "0x687CF0", Offset = "0x686AF0", VA = "0x10687CF0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600A6F9")]
    [Address(RVA = "0x492EB0", Offset = "0x491CB0", VA = "0x10492EB0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600A6FA")]
    [Address(RVA = "0x687DB0", Offset = "0x686BB0", VA = "0x10687DB0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600A6FB")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public GuildRaidRankingGuildParam()
    {
    }
  }
}
