// Decompiled with JetBrains decompiler
// Type: SRPG.SimpleDropTableParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D1E")]
  public class SimpleDropTableParam
  {
    [Token(Token = "0x4007237")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007238")]
    [FieldOffset(Offset = "0x10")]
    public DateTime beginAt;
    [Token(Token = "0x4007239")]
    [FieldOffset(Offset = "0x18")]
    public DateTime endAt;
    [Token(Token = "0x400723A")]
    [FieldOffset(Offset = "0x20")]
    public string[] dropList;
    [Token(Token = "0x400723B")]
    [FieldOffset(Offset = "0x24")]
    public string[] dropcards;

    [Token(Token = "0x600777B")]
    [Address(RVA = "0x39F750", Offset = "0x39E550", VA = "0x1039F750")]
    public bool Deserialize(JSON_SimpleDropTableParam json) => new bool();

    [Token(Token = "0x600777C")]
    [Address(RVA = "0x39F870", Offset = "0x39E670", VA = "0x1039F870")]
    public bool IsAvailablePeriod(DateTime now) => new bool();

    [Token(Token = "0x17000FC6")]
    public string GetCommonName
    {
      [Token(Token = "0x600777D"), Address(RVA = "0x39F910", Offset = "0x39E710", VA = "0x1039F910")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FC7")]
    public bool IsSuffix
    {
      [Token(Token = "0x600777E"), Address(RVA = "0x39F980", Offset = "0x39E780", VA = "0x1039F980")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600777F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SimpleDropTableParam()
    {
    }
  }
}
