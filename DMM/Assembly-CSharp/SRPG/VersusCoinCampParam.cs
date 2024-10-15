// Decompiled with JetBrains decompiler
// Type: SRPG.VersusCoinCampParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EAF")]
  public class VersusCoinCampParam
  {
    [Token(Token = "0x4008085")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4008086")]
    [FieldOffset(Offset = "0x10")]
    public DateTime begin_at;
    [Token(Token = "0x4008087")]
    [FieldOffset(Offset = "0x18")]
    public DateTime end_at;
    [Token(Token = "0x4008088")]
    [FieldOffset(Offset = "0x20")]
    public int coinrate;

    [Token(Token = "0x6007DC7")]
    [Address(RVA = "0x3F7ED0", Offset = "0x3F6CD0", VA = "0x103F7ED0")]
    public bool Deserialize(JSON_VersusCoinCampParam json) => new bool();

    [Token(Token = "0x6007DC8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusCoinCampParam()
    {
    }
  }
}
