// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideReleasePanelFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005BA")]
  public sealed class JSON_RunePrideReleasePanelFormatter : 
    IMessagePackFormatter<JSON_RunePrideReleasePanel>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400100C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400100D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A7C")]
    [Address(RVA = "0x7927E0", Offset = "0x7915E0", VA = "0x107927E0")]
    public JSON_RunePrideReleasePanelFormatter()
    {
    }

    [Token(Token = "0x6001A7D")]
    [Address(RVA = "0x792600", Offset = "0x791400", VA = "0x10792600", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideReleasePanel value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A7E")]
    [Address(RVA = "0x7922C0", Offset = "0x7910C0", VA = "0x107922C0", Slot = "5")]
    public JSON_RunePrideReleasePanel Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideReleasePanel) null;
    }
  }
}
