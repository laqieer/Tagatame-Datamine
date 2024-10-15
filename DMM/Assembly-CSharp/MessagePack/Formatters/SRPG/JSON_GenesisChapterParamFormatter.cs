// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GenesisChapterParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008D7")]
  public sealed class JSON_GenesisChapterParamFormatter : 
    IMessagePackFormatter<JSON_GenesisChapterParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400163E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400163F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023D3")]
    [Address(RVA = "0xDCF660", Offset = "0xDCE460", VA = "0x10DCF660")]
    public JSON_GenesisChapterParamFormatter()
    {
    }

    [Token(Token = "0x60023D4")]
    [Address(RVA = "0xDCF1F0", Offset = "0xDCDFF0", VA = "0x10DCF1F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GenesisChapterParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023D5")]
    [Address(RVA = "0xDCEC40", Offset = "0xDCDA40", VA = "0x10DCEC40", Slot = "5")]
    public JSON_GenesisChapterParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GenesisChapterParam) null;
    }
  }
}
