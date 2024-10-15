// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePridePanelPatternParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006E1")]
  public sealed class JSON_RunePridePanelPatternParamFormatter : 
    IMessagePackFormatter<JSON_RunePridePanelPatternParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400125A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400125B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DF1")]
    [Address(RVA = "0xC32500", Offset = "0xC31300", VA = "0x10C32500")]
    public JSON_RunePridePanelPatternParamFormatter()
    {
    }

    [Token(Token = "0x6001DF2")]
    [Address(RVA = "0xC323A0", Offset = "0xC311A0", VA = "0x10C323A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePridePanelPatternParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DF3")]
    [Address(RVA = "0xC32060", Offset = "0xC30E60", VA = "0x10C32060", Slot = "5")]
    public JSON_RunePridePanelPatternParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePridePanelPatternParam) null;
    }
  }
}
