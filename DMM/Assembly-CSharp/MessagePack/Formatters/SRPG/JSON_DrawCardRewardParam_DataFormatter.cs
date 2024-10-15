// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DrawCardRewardParam_DataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200065D")]
  public sealed class JSON_DrawCardRewardParam_DataFormatter : 
    IMessagePackFormatter<JSON_DrawCardRewardParam.Data>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001152")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001153")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C65")]
    [Address(RVA = "0xBE1F60", Offset = "0xBE0D60", VA = "0x10BE1F60")]
    public JSON_DrawCardRewardParam_DataFormatter()
    {
    }

    [Token(Token = "0x6001C66")]
    [Address(RVA = "0xBE1DC0", Offset = "0xBE0BC0", VA = "0x10BE1DC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DrawCardRewardParam.Data value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C67")]
    [Address(RVA = "0xBE1A40", Offset = "0xBE0840", VA = "0x10BE1A40", Slot = "5")]
    public JSON_DrawCardRewardParam.Data Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DrawCardRewardParam.Data) null;
    }
  }
}
