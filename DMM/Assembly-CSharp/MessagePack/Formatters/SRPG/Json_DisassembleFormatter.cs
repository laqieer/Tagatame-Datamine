// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_DisassembleFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007E9")]
  public sealed class Json_DisassembleFormatter : 
    IMessagePackFormatter<Json_Disassemble>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001462")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001463")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002109")]
    [Address(RVA = "0xD36340", Offset = "0xD35140", VA = "0x10D36340")]
    public Json_DisassembleFormatter()
    {
    }

    [Token(Token = "0x600210A")]
    [Address(RVA = "0xD36210", Offset = "0xD35010", VA = "0x10D36210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Disassemble value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600210B")]
    [Address(RVA = "0xD35F00", Offset = "0xD34D00", VA = "0x10D35F00", Slot = "5")]
    public Json_Disassemble Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Disassemble) null;
    }
  }
}
