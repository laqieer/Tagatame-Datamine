// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_ResonanceFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005B8")]
  public sealed class Json_ResonanceFormatter : 
    IMessagePackFormatter<Json_Resonance>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001008")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001009")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A76")]
    [Address(RVA = "0x79E3B0", Offset = "0x79D1B0", VA = "0x1079E3B0")]
    public Json_ResonanceFormatter()
    {
    }

    [Token(Token = "0x6001A77")]
    [Address(RVA = "0x79E280", Offset = "0x79D080", VA = "0x1079E280", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Resonance value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A78")]
    [Address(RVA = "0x79DF40", Offset = "0x79CD40", VA = "0x1079DF40", Slot = "5")]
    public Json_Resonance Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Resonance) null;
    }
  }
}
