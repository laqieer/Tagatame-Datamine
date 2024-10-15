// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PlayerGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F80")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_PlayerGuild
  {
    [Token(Token = "0x4003657")]
    [FieldOffset(Offset = "0x8")]
    public int gid;
    [Token(Token = "0x4003658")]
    [FieldOffset(Offset = "0xC")]
    public string guild_name;
    [Token(Token = "0x4003659")]
    [FieldOffset(Offset = "0x10")]
    public int role_id;
    [Token(Token = "0x400365A")]
    [FieldOffset(Offset = "0x18")]
    public long applied_at;
    [Token(Token = "0x400365B")]
    [FieldOffset(Offset = "0x20")]
    public long joined_at;
    [Token(Token = "0x400365C")]
    [FieldOffset(Offset = "0x28")]
    public long leaved_at;
    [Token(Token = "0x400365D")]
    [FieldOffset(Offset = "0x30")]
    public long invest_at;

    [Token(Token = "0x6004053")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PlayerGuild()
    {
    }
  }
}
