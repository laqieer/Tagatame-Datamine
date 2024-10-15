// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PartyOverWriteFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005A5")]
  public sealed class JSON_PartyOverWriteFormatter : 
    IMessagePackFormatter<JSON_PartyOverWrite>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FE2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FE3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A3D")]
    [Address(RVA = "0x791070", Offset = "0x78FE70", VA = "0x10791070")]
    public JSON_PartyOverWriteFormatter()
    {
    }

    [Token(Token = "0x6001A3E")]
    [Address(RVA = "0x790E60", Offset = "0x78FC60", VA = "0x10790E60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PartyOverWrite value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A3F")]
    [Address(RVA = "0x790AE0", Offset = "0x78F8E0", VA = "0x10790AE0", Slot = "5")]
    public JSON_PartyOverWrite Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PartyOverWrite) null;
    }
  }
}
