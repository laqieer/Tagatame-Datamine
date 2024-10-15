// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BuyCoinProductParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200063D")]
  public sealed class JSON_BuyCoinProductParamFormatter : 
    IMessagePackFormatter<JSON_BuyCoinProductParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001112")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001113")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C05")]
    [Address(RVA = "0xBCC2C0", Offset = "0xBCB0C0", VA = "0x10BCC2C0")]
    public JSON_BuyCoinProductParamFormatter()
    {
    }

    [Token(Token = "0x6001C06")]
    [Address(RVA = "0xBCBD10", Offset = "0xBCAB10", VA = "0x10BCBD10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BuyCoinProductParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C07")]
    [Address(RVA = "0xBCB5F0", Offset = "0xBCA3F0", VA = "0x10BCB5F0", Slot = "5")]
    public JSON_BuyCoinProductParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BuyCoinProductParam) null;
    }
  }
}
