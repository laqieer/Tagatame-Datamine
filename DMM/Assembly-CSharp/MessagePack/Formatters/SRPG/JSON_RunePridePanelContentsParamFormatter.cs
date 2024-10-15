// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePridePanelContentsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006E3")]
  public sealed class JSON_RunePridePanelContentsParamFormatter : 
    IMessagePackFormatter<JSON_RunePridePanelContentsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400125E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400125F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DF7")]
    [Address(RVA = "0xC316F0", Offset = "0xC304F0", VA = "0x10C316F0")]
    public JSON_RunePridePanelContentsParamFormatter()
    {
    }

    [Token(Token = "0x6001DF8")]
    [Address(RVA = "0xC31510", Offset = "0xC30310", VA = "0x10C31510", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePridePanelContentsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DF9")]
    [Address(RVA = "0xC311D0", Offset = "0xC2FFD0", VA = "0x10C311D0", Slot = "5")]
    public JSON_RunePridePanelContentsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePridePanelContentsParam) null;
    }
  }
}
