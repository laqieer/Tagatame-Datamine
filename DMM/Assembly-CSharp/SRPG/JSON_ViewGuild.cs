// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ViewGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F82")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ViewGuild
  {
    [Token(Token = "0x400366E")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400366F")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4003670")]
    [FieldOffset(Offset = "0x10")]
    public string award_id;
    [Token(Token = "0x4003671")]
    [FieldOffset(Offset = "0x14")]
    public int level;
    [Token(Token = "0x4003672")]
    [FieldOffset(Offset = "0x18")]
    public int count;
    [Token(Token = "0x4003673")]
    [FieldOffset(Offset = "0x1C")]
    public int max_count;
    [Token(Token = "0x4003674")]
    [FieldOffset(Offset = "0x20")]
    public string guild_master;
    [Token(Token = "0x4003675")]
    [FieldOffset(Offset = "0x28")]
    public long created_at;

    [Token(Token = "0x1700055E")]
    [IgnoreMember]
    public bool IsEmptyData
    {
      [Token(Token = "0x6004055"), Address(RVA = "0x4F7560", Offset = "0x4F6360", VA = "0x104F7560")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004056")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ViewGuild()
    {
    }
  }
}
