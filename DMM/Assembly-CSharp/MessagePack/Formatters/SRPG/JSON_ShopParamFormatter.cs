// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ShopParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005E9")]
  public sealed class JSON_ShopParamFormatter : 
    IMessagePackFormatter<JSON_ShopParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400106A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400106B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B09")]
    [Address(RVA = "0xB9C2D0", Offset = "0xB9B0D0", VA = "0x10B9C2D0")]
    public JSON_ShopParamFormatter()
    {
    }

    [Token(Token = "0x6001B0A")]
    [Address(RVA = "0xB9C130", Offset = "0xB9AF30", VA = "0x10B9C130", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ShopParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B0B")]
    [Address(RVA = "0xB9BDB0", Offset = "0xB9ABB0", VA = "0x10B9BDB0", Slot = "5")]
    public JSON_ShopParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ShopParam) null;
    }
  }
}
