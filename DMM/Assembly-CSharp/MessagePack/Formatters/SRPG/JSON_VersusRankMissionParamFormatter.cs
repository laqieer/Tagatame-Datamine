// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusRankMissionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A77")]
  public sealed class JSON_VersusRankMissionParamFormatter : 
    IMessagePackFormatter<JSON_VersusRankMissionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400197E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400197F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028B3")]
    [Address(RVA = "0xEE6940", Offset = "0xEE5740", VA = "0x10EE6940")]
    public JSON_VersusRankMissionParamFormatter()
    {
    }

    [Token(Token = "0x60028B4")]
    [Address(RVA = "0xEE6670", Offset = "0xEE5470", VA = "0x10EE6670", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusRankMissionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028B5")]
    [Address(RVA = "0xEE61E0", Offset = "0xEE4FE0", VA = "0x10EE61E0", Slot = "5")]
    public JSON_VersusRankMissionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusRankMissionParam) null;
    }
  }
}
