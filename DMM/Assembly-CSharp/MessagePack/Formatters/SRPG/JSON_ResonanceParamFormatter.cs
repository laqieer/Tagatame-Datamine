// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResonanceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006C3")]
  public sealed class JSON_ResonanceParamFormatter : 
    IMessagePackFormatter<JSON_ResonanceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400121E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400121F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D97")]
    [Address(RVA = "0xC19A70", Offset = "0xC18870", VA = "0x10C19A70")]
    public JSON_ResonanceParamFormatter()
    {
    }

    [Token(Token = "0x6001D98")]
    [Address(RVA = "0xC197D0", Offset = "0xC185D0", VA = "0x10C197D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResonanceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D99")]
    [Address(RVA = "0xC193F0", Offset = "0xC181F0", VA = "0x10C193F0", Slot = "5")]
    public JSON_ResonanceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResonanceParam) null;
    }
  }
}
