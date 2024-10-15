// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidRankingGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FA6")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidRankingGuild : JSON_ViewGuild
  {
    [Token(Token = "0x400371B")]
    [FieldOffset(Offset = "0x30")]
    public int member_count;
    [Token(Token = "0x400371C")]
    [FieldOffset(Offset = "0x34")]
    public int member_max;

    [Token(Token = "0x60040D0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidRankingGuild()
    {
    }
  }
}
