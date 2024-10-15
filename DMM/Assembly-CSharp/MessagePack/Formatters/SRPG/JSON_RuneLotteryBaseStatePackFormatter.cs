// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneLotteryBaseStatePackFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200067A")]
  public sealed class JSON_RuneLotteryBaseStatePackFormatter : 
    IMessagePackFormatter<JSON_RuneLotteryBaseStatePack>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400118C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400118D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CBC")]
    [Address(RVA = "0xBE9910", Offset = "0xBE8710", VA = "0x10BE9910")]
    public JSON_RuneLotteryBaseStatePackFormatter()
    {
    }

    [Token(Token = "0x6001CBD")]
    [Address(RVA = "0xBE9730", Offset = "0xBE8530", VA = "0x10BE9730", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneLotteryBaseStatePack value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CBE")]
    [Address(RVA = "0xBE93F0", Offset = "0xBE81F0", VA = "0x10BE93F0", Slot = "5")]
    public JSON_RuneLotteryBaseStatePack Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneLotteryBaseStatePack) null;
    }
  }
}
