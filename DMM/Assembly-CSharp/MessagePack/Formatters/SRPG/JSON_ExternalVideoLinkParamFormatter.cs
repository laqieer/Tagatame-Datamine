// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ExternalVideoLinkParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006A2")]
  public sealed class JSON_ExternalVideoLinkParamFormatter : 
    IMessagePackFormatter<JSON_ExternalVideoLinkParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011DC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011DD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D34")]
    [Address(RVA = "0xBFA300", Offset = "0xBF9100", VA = "0x10BFA300")]
    public JSON_ExternalVideoLinkParamFormatter()
    {
    }

    [Token(Token = "0x6001D35")]
    [Address(RVA = "0xBFA020", Offset = "0xBF8E20", VA = "0x10BFA020", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ExternalVideoLinkParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D36")]
    [Address(RVA = "0xBF9B80", Offset = "0xBF8980", VA = "0x10BF9B80", Slot = "5")]
    public JSON_ExternalVideoLinkParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ExternalVideoLinkParam) null;
    }
  }
}
