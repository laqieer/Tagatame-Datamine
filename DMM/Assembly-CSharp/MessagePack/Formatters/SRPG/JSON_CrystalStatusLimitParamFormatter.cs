// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalStatusLimitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006D2")]
  public sealed class JSON_CrystalStatusLimitParamFormatter : 
    IMessagePackFormatter<JSON_CrystalStatusLimitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400123C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400123D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DC4")]
    [Address(RVA = "0xC14930", Offset = "0xC13730", VA = "0x10C14930")]
    public JSON_CrystalStatusLimitParamFormatter()
    {
    }

    [Token(Token = "0x6001DC5")]
    [Address(RVA = "0xC14830", Offset = "0xC13630", VA = "0x10C14830", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalStatusLimitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DC6")]
    [Address(RVA = "0xC14550", Offset = "0xC13350", VA = "0x10C14550", Slot = "5")]
    public JSON_CrystalStatusLimitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalStatusLimitParam) null;
    }
  }
}
