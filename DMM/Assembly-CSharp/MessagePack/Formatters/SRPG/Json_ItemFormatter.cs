// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_ItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005A6")]
  public sealed class Json_ItemFormatter : IMessagePackFormatter<Json_Item>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FE4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FE5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A40")]
    [Address(RVA = "0x79BF30", Offset = "0x79AD30", VA = "0x1079BF30")]
    public Json_ItemFormatter()
    {
    }

    [Token(Token = "0x6001A41")]
    [Address(RVA = "0x79BD70", Offset = "0x79AB70", VA = "0x1079BD70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Item value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A42")]
    [Address(RVA = "0x79B9C0", Offset = "0x79A7C0", VA = "0x1079B9C0", Slot = "5")]
    public Json_Item Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Item) null;
    }
  }
}
