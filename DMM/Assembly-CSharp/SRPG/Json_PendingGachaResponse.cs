// Decompiled with JetBrains decompiler
// Type: SRPG.Json_PendingGachaResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014FD")]
  public class Json_PendingGachaResponse
  {
    [Token(Token = "0x4004CDC")]
    [FieldOffset(Offset = "0x8")]
    public Json_DropInfo[] add;
    [Token(Token = "0x4004CDD")]
    [FieldOffset(Offset = "0xC")]
    public Json_DropInfo[] add_mail;
    [Token(Token = "0x4004CDE")]
    [FieldOffset(Offset = "0x10")]
    public Json_PendingGachaParam gacha;
    [Token(Token = "0x4004CDF")]
    [FieldOffset(Offset = "0x14")]
    public int rest;
    [Token(Token = "0x4004CE0")]
    [FieldOffset(Offset = "0x18")]
    public Json_DropDisassembly disassembly;

    [Token(Token = "0x6005746")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_PendingGachaResponse()
    {
    }
  }
}
