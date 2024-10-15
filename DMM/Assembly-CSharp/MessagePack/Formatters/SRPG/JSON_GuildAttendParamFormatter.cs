// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildAttendParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200068E")]
  public sealed class JSON_GuildAttendParamFormatter : 
    IMessagePackFormatter<JSON_GuildAttendParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011B4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011B5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CF8")]
    [Address(RVA = "0xBFB380", Offset = "0xBFA180", VA = "0x10BFB380")]
    public JSON_GuildAttendParamFormatter()
    {
    }

    [Token(Token = "0x6001CF9")]
    [Address(RVA = "0xBFB100", Offset = "0xBF9F00", VA = "0x10BFB100", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildAttendParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CFA")]
    [Address(RVA = "0xBFAD40", Offset = "0xBF9B40", VA = "0x10BFAD40", Slot = "5")]
    public JSON_GuildAttendParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildAttendParam) null;
    }
  }
}
