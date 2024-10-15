// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneFavorite_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200099C")]
  public sealed class ReqRuneFavorite_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneFavorite.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017C8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017C9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002622")]
    [Address(RVA = "0xE46760", Offset = "0xE45560", VA = "0x10E46760")]
    public ReqRuneFavorite_RequestParamFormatter()
    {
    }

    [Token(Token = "0x6002623")]
    [Address(RVA = "0xE46660", Offset = "0xE45460", VA = "0x10E46660", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneFavorite.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002624")]
    [Address(RVA = "0xE46360", Offset = "0xE45160", VA = "0x10E46360", Slot = "5")]
    public ReqRuneFavorite.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneFavorite.RequestParam) null;
    }
  }
}
