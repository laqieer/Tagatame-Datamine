// Decompiled with JetBrains decompiler
// Type: SRPG.ViewGuildData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F8E")]
  [MessagePackObject(true)]
  public class ViewGuildData
  {
    [Token(Token = "0x40036BB")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40036BC")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40036BD")]
    [FieldOffset(Offset = "0x10")]
    public string award_id;
    [Token(Token = "0x40036BE")]
    [FieldOffset(Offset = "0x14")]
    public int level;
    [Token(Token = "0x40036BF")]
    [FieldOffset(Offset = "0x18")]
    public int count;
    [Token(Token = "0x40036C0")]
    [FieldOffset(Offset = "0x1C")]
    public int max_count;
    [Token(Token = "0x40036C1")]
    [FieldOffset(Offset = "0x20")]
    public string guild_master;
    [Token(Token = "0x40036C2")]
    [FieldOffset(Offset = "0x28")]
    public DateTime create_at;

    [Token(Token = "0x60040A0")]
    [Address(RVA = "0x119D0F0", Offset = "0x119BEF0", VA = "0x1119D0F0")]
    public void Deserialize(JSON_ViewGuild json)
    {
    }

    [Token(Token = "0x60040A1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ViewGuildData()
    {
    }
  }
}
