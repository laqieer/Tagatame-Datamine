// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_CaveFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000717")]
  public sealed class Json_CaveFormatter : IMessagePackFormatter<Json_Cave>, IMessagePackFormatter
  {
    [Token(Token = "0x40012C6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012C7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E93")]
    [Address(RVA = "0xC5E990", Offset = "0xC5D790", VA = "0x10C5E990")]
    public Json_CaveFormatter()
    {
    }

    [Token(Token = "0x6001E94")]
    [Address(RVA = "0xC5E890", Offset = "0xC5D690", VA = "0x10C5E890", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Cave value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E95")]
    [Address(RVA = "0xC5E590", Offset = "0xC5D390", VA = "0x10C5E590", Slot = "5")]
    public Json_Cave Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Cave) null;
    }
  }
}
