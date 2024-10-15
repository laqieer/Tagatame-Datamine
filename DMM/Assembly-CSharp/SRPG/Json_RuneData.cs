// Decompiled with JetBrains decompiler
// Type: SRPG.Json_RuneData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010EB")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_RuneData
  {
    [Token(Token = "0x4003D21")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x4003D22")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x4003D23")]
    [FieldOffset(Offset = "0x14")]
    public int unit_id;
    [Token(Token = "0x4003D24")]
    [FieldOffset(Offset = "0x18")]
    public int slot;
    [Token(Token = "0x4003D25")]
    [FieldOffset(Offset = "0x1C")]
    public int enforce;
    [Token(Token = "0x4003D26")]
    [FieldOffset(Offset = "0x20")]
    public int evo;
    [Token(Token = "0x4003D27")]
    [FieldOffset(Offset = "0x24")]
    public int favorite;
    [Token(Token = "0x4003D28")]
    [FieldOffset(Offset = "0x28")]
    public Json_RuneStateData state;
    [Token(Token = "0x4003D29")]
    [FieldOffset(Offset = "0x2C")]
    public int is_disassemble;

    [Token(Token = "0x17000743")]
    [IgnoreMember]
    public bool IsEmptyDummyData
    {
      [Token(Token = "0x6004781"), Address(RVA = "0x10F0560", Offset = "0x10EF360", VA = "0x110F0560")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000744")]
    [IgnoreMember]
    public bool IsFavorite
    {
      [Token(Token = "0x6004782"), Address(RVA = "0x11DDBB0", Offset = "0x11DC9B0", VA = "0x111DDBB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004783")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_RuneData()
    {
    }
  }
}
