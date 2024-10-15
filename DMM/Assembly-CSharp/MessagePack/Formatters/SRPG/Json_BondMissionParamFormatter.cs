// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondMissionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006BB")]
  public sealed class Json_BondMissionParamFormatter : 
    IMessagePackFormatter<Json_BondMissionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400120E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400120F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D7F")]
    [Address(RVA = "0xC1FC10", Offset = "0xC1EA10", VA = "0x10C1FC10")]
    public Json_BondMissionParamFormatter()
    {
    }

    [Token(Token = "0x6001D80")]
    [Address(RVA = "0xC1F940", Offset = "0xC1E740", VA = "0x10C1F940", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondMissionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D81")]
    [Address(RVA = "0xC1F520", Offset = "0xC1E320", VA = "0x10C1F520", Slot = "5")]
    public Json_BondMissionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondMissionParam) null;
    }
  }
}
