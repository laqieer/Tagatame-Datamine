// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BtlPointResultFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200070B")]
  public sealed class Json_BtlPointResultFormatter : 
    IMessagePackFormatter<Json_BtlPointResult>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012AE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012AF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E6F")]
    [Address(RVA = "0xC5E3A0", Offset = "0xC5D1A0", VA = "0x10C5E3A0")]
    public Json_BtlPointResultFormatter()
    {
    }

    [Token(Token = "0x6001E70")]
    [Address(RVA = "0xC5E1C0", Offset = "0xC5CFC0", VA = "0x10C5E1C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BtlPointResult value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E71")]
    [Address(RVA = "0xC5DE70", Offset = "0xC5CC70", VA = "0x10C5DE70", Slot = "5")]
    public Json_BtlPointResult Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BtlPointResult) null;
    }
  }
}
