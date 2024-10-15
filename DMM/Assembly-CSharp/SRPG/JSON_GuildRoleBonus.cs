// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRoleBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B28")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRoleBonus
  {
    [Token(Token = "0x400677B")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400677C")]
    [FieldOffset(Offset = "0xC")]
    public int role;
    [Token(Token = "0x400677D")]
    [FieldOffset(Offset = "0x10")]
    public string start_at;
    [Token(Token = "0x400677E")]
    [FieldOffset(Offset = "0x14")]
    public string end_at;
    [Token(Token = "0x400677F")]
    [FieldOffset(Offset = "0x18")]
    public JSON_GuildRoleBonusDetail[] rewards;

    [Token(Token = "0x6006FF7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRoleBonus()
    {
    }
  }
}
