// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_TrophyPlayerDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200087A")]
  public sealed class Json_TrophyPlayerDataFormatter : 
    IMessagePackFormatter<Json_TrophyPlayerData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001584")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001585")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022BC")]
    [Address(RVA = "0xDA8F30", Offset = "0xDA7D30", VA = "0x10DA8F30")]
    public Json_TrophyPlayerDataFormatter()
    {
    }

    [Token(Token = "0x60022BD")]
    [Address(RVA = "0xDA8C70", Offset = "0xDA7A70", VA = "0x10DA8C70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_TrophyPlayerData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022BE")]
    [Address(RVA = "0xDA88C0", Offset = "0xDA76C0", VA = "0x10DA88C0", Slot = "5")]
    public Json_TrophyPlayerData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_TrophyPlayerData) null;
    }
  }
}
