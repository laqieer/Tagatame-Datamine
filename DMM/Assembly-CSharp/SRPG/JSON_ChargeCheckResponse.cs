﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ChargeCheckResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E81")]
  public class JSON_ChargeCheckResponse
  {
    [Token(Token = "0x4002C83")]
    [FieldOffset(Offset = "0x8")]
    public int age;
    [Token(Token = "0x4002C84")]
    [FieldOffset(Offset = "0xC")]
    public string[] accept_ids;
    [Token(Token = "0x4002C85")]
    [FieldOffset(Offset = "0x10")]
    public string[] reject_ids;

    [Token(Token = "0x6003C2A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ChargeCheckResponse()
    {
    }
  }
}