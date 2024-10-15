// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ProductParamResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B2C")]
  public sealed class JSON_ProductParamResponseFormatter : 
    IMessagePackFormatter<JSON_ProductParamResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AE8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AE9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AD2")]
    [Address(RVA = "0xF684A0", Offset = "0xF672A0", VA = "0x10F684A0")]
    public JSON_ProductParamResponseFormatter()
    {
    }

    [Token(Token = "0x6002AD3")]
    [Address(RVA = "0xF68060", Offset = "0xF66E60", VA = "0x10F68060", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ProductParamResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AD4")]
    [Address(RVA = "0xF67BF0", Offset = "0xF669F0", VA = "0x10F67BF0", Slot = "5")]
    public JSON_ProductParamResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ProductParamResponse) null;
    }
  }
}
