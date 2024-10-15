// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidBossParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EF9")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidBossParam
  {
    [Token(Token = "0x400826C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400826D")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400826E")]
    [FieldOffset(Offset = "0x10")]
    public long hp;
    [Token(Token = "0x400826F")]
    [FieldOffset(Offset = "0x18")]
    public string unit_id;
    [Token(Token = "0x4008270")]
    [FieldOffset(Offset = "0x1C")]
    public string quest_id;
    [Token(Token = "0x4008271")]
    [FieldOffset(Offset = "0x20")]
    public string detail_url;
    [Token(Token = "0x4008272")]
    [FieldOffset(Offset = "0x24")]
    public string detail_title;

    [Token(Token = "0x6007EA1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidBossParam()
    {
    }
  }
}
