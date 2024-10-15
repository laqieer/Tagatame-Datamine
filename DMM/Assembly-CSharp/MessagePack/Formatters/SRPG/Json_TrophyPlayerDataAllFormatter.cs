// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_TrophyPlayerDataAllFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200087F")]
  public sealed class Json_TrophyPlayerDataAllFormatter : 
    IMessagePackFormatter<Json_TrophyPlayerDataAll>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400158E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400158F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022CB")]
    [Address(RVA = "0xDA8590", Offset = "0xDA7390", VA = "0x10DA8590")]
    public Json_TrophyPlayerDataAllFormatter()
    {
    }

    [Token(Token = "0x60022CC")]
    [Address(RVA = "0xDA80E0", Offset = "0xDA6EE0", VA = "0x10DA80E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_TrophyPlayerDataAll value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022CD")]
    [Address(RVA = "0xDA7C00", Offset = "0xDA6A00", VA = "0x10DA7C00", Slot = "5")]
    public Json_TrophyPlayerDataAll Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_TrophyPlayerDataAll) null;
    }
  }
}
