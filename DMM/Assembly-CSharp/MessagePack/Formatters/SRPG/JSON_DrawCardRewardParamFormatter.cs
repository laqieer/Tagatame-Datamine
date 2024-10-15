// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DrawCardRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200065E")]
  public sealed class JSON_DrawCardRewardParamFormatter : 
    IMessagePackFormatter<JSON_DrawCardRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001154")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001155")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C68")]
    [Address(RVA = "0xBE18C0", Offset = "0xBE06C0", VA = "0x10BE18C0")]
    public JSON_DrawCardRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001C69")]
    [Address(RVA = "0xBE16E0", Offset = "0xBE04E0", VA = "0x10BE16E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DrawCardRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C6A")]
    [Address(RVA = "0xBE13A0", Offset = "0xBE01A0", VA = "0x10BE13A0", Slot = "5")]
    public JSON_DrawCardRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DrawCardRewardParam) null;
    }
  }
}
