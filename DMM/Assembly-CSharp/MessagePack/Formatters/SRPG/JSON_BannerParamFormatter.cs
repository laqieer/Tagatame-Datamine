// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BannerParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005F6")]
  public sealed class JSON_BannerParamFormatter : 
    IMessagePackFormatter<JSON_BannerParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001084")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001085")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B30")]
    [Address(RVA = "0xBA4B40", Offset = "0xBA3940", VA = "0x10BA4B40")]
    public JSON_BannerParamFormatter()
    {
    }

    [Token(Token = "0x6001B31")]
    [Address(RVA = "0xBA4720", Offset = "0xBA3520", VA = "0x10BA4720", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BannerParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B32")]
    [Address(RVA = "0xBA4150", Offset = "0xBA2F50", VA = "0x10BA4150", Slot = "5")]
    public JSON_BannerParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BannerParam) null;
    }
  }
}
