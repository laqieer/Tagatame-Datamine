// Decompiled with JetBrains decompiler
// Type: SRPG.Json_MailOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001026")]
  public class Json_MailOption
  {
    [Token(Token = "0x4003976")]
    [FieldOffset(Offset = "0x8")]
    public int totalCount;
    [Token(Token = "0x4003977")]
    [FieldOffset(Offset = "0xC")]
    public int totalPage;
    [Token(Token = "0x4003978")]
    [FieldOffset(Offset = "0x10")]
    public int currentPage;
    [Token(Token = "0x4003979")]
    [FieldOffset(Offset = "0x14")]
    public byte hasNext;
    [Token(Token = "0x400397A")]
    [FieldOffset(Offset = "0x15")]
    public byte hasPrev;

    [Token(Token = "0x600428B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_MailOption()
    {
    }
  }
}
