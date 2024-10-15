// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GenesisStarParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008C6")]
  public sealed class JSON_GenesisStarParamFormatter : 
    IMessagePackFormatter<JSON_GenesisStarParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400161C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400161D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023A0")]
    [Address(RVA = "0xDD0FE0", Offset = "0xDCFDE0", VA = "0x10DD0FE0")]
    public JSON_GenesisStarParamFormatter()
    {
    }

    [Token(Token = "0x60023A1")]
    [Address(RVA = "0xDD0E00", Offset = "0xDCFC00", VA = "0x10DD0E00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GenesisStarParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023A2")]
    [Address(RVA = "0xDD0AC0", Offset = "0xDCF8C0", VA = "0x10DD0AC0", Slot = "5")]
    public JSON_GenesisStarParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GenesisStarParam) null;
    }
  }
}
