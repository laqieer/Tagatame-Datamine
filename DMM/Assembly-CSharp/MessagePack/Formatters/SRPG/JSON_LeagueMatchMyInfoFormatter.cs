// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchMyInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200080E")]
  public sealed class JSON_LeagueMatchMyInfoFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchMyInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014AC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014AD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002178")]
    [Address(RVA = "0xD46360", Offset = "0xD45160", VA = "0x10D46360")]
    public JSON_LeagueMatchMyInfoFormatter()
    {
    }

    [Token(Token = "0x6002179")]
    [Address(RVA = "0xD46200", Offset = "0xD45000", VA = "0x10D46200", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchMyInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600217A")]
    [Address(RVA = "0xD45EB0", Offset = "0xD44CB0", VA = "0x10D45EB0", Slot = "5")]
    public JSON_LeagueMatchMyInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchMyInfo) null;
    }
  }
}
