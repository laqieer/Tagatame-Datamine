// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_PaidGachaFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200071E")]
  public sealed class Json_PaidGachaFormatter : 
    IMessagePackFormatter<Json_PaidGacha>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012D4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012D5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EA8")]
    [Address(RVA = "0xC61310", Offset = "0xC60110", VA = "0x10C61310")]
    public Json_PaidGachaFormatter()
    {
    }

    [Token(Token = "0x6001EA9")]
    [Address(RVA = "0xC61210", Offset = "0xC60010", VA = "0x10C61210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_PaidGacha value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EAA")]
    [Address(RVA = "0xC60F10", Offset = "0xC5FD10", VA = "0x10C60F10", Slot = "5")]
    public Json_PaidGacha Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_PaidGacha) null;
    }
  }
}
