// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideSubMatsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A27")]
  public sealed class JSON_RunePrideSubMatsFormatter : 
    IMessagePackFormatter<JSON_RunePrideSubMats>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018DE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018DF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027C3")]
    [Address(RVA = "0xEA32C0", Offset = "0xEA20C0", VA = "0x10EA32C0")]
    public JSON_RunePrideSubMatsFormatter()
    {
    }

    [Token(Token = "0x60027C4")]
    [Address(RVA = "0xEA3190", Offset = "0xEA1F90", VA = "0x10EA3190", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideSubMats value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027C5")]
    [Address(RVA = "0xEA2E80", Offset = "0xEA1C80", VA = "0x10EA2E80", Slot = "5")]
    public JSON_RunePrideSubMats Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideSubMats) null;
    }
  }
}
