// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F83")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildMember
  {
    [Token(Token = "0x4003676")]
    [FieldOffset(Offset = "0x8")]
    public long gid;
    [Token(Token = "0x4003677")]
    [FieldOffset(Offset = "0x10")]
    public string uid;
    [Token(Token = "0x4003678")]
    [FieldOffset(Offset = "0x14")]
    public int role_id;
    [Token(Token = "0x4003679")]
    [FieldOffset(Offset = "0x18")]
    public string name;
    [Token(Token = "0x400367A")]
    [FieldOffset(Offset = "0x1C")]
    public int lv;
    [Token(Token = "0x400367B")]
    [FieldOffset(Offset = "0x20")]
    public string award_id;
    [Token(Token = "0x400367C")]
    [FieldOffset(Offset = "0x24")]
    public Json_Unit units;
    [Token(Token = "0x400367D")]
    [FieldOffset(Offset = "0x28")]
    public long applied_at;
    [Token(Token = "0x400367E")]
    [FieldOffset(Offset = "0x30")]
    public long joined_at;
    [Token(Token = "0x400367F")]
    [FieldOffset(Offset = "0x38")]
    public long leave_at;
    [Token(Token = "0x4003680")]
    [FieldOffset(Offset = "0x40")]
    public long lastlogin;
    [Token(Token = "0x4003681")]
    [FieldOffset(Offset = "0x48")]
    public JSON_PlayerBuff player_buff;

    [Token(Token = "0x6004057")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildMember()
    {
    }
  }
}
