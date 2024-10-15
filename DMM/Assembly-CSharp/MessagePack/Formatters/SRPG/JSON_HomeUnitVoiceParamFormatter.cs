// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_HomeUnitVoiceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006CE")]
  public sealed class JSON_HomeUnitVoiceParamFormatter : 
    IMessagePackFormatter<JSON_HomeUnitVoiceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001234")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001235")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DB8")]
    [Address(RVA = "0xC16870", Offset = "0xC15670", VA = "0x10C16870")]
    public JSON_HomeUnitVoiceParamFormatter()
    {
    }

    [Token(Token = "0x6001DB9")]
    [Address(RVA = "0xC16710", Offset = "0xC15510", VA = "0x10C16710", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_HomeUnitVoiceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DBA")]
    [Address(RVA = "0xC163D0", Offset = "0xC151D0", VA = "0x10C163D0", Slot = "5")]
    public JSON_HomeUnitVoiceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_HomeUnitVoiceParam) null;
    }
  }
}
