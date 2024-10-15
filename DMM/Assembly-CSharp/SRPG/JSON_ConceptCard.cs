// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ConceptCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E85")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ConceptCard
  {
    [Token(Token = "0x4002C8D")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x4002C8E")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x4002C8F")]
    [FieldOffset(Offset = "0x14")]
    public int exp;
    [Token(Token = "0x4002C90")]
    [FieldOffset(Offset = "0x18")]
    public int trust;
    [Token(Token = "0x4002C91")]
    [FieldOffset(Offset = "0x1C")]
    public int fav;
    [Token(Token = "0x4002C92")]
    [FieldOffset(Offset = "0x20")]
    public int trust_bonus;
    [Token(Token = "0x4002C93")]
    [FieldOffset(Offset = "0x24")]
    public int plus;
    [Token(Token = "0x4002C94")]
    [FieldOffset(Offset = "0x28")]
    public int leaderskill;
    [Token(Token = "0x4002C95")]
    [FieldOffset(Offset = "0x2C")]
    public int extra_rarity_point;
    [Token(Token = "0x4002C96")]
    [FieldOffset(Offset = "0x30")]
    public int extra_rarity_flg;

    [Token(Token = "0x17000485")]
    [IgnoreMember]
    public bool IsEmptyDummyData
    {
      [Token(Token = "0x6003C33"), Address(RVA = "0x10F0560", Offset = "0x10EF360", VA = "0x110F0560")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000486")]
    [IgnoreMember]
    public bool EnableLeaderSkill
    {
      [Token(Token = "0x6003C34"), Address(RVA = "0x59D8E0", Offset = "0x59C6E0", VA = "0x1059D8E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003C35")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ConceptCard()
    {
    }
  }
}
