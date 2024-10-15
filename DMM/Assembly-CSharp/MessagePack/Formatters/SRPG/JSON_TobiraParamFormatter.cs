// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TobiraParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000608")]
  public sealed class JSON_TobiraParamFormatter : 
    IMessagePackFormatter<JSON_TobiraParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010A8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010A9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B66")]
    [Address(RVA = "0xBACF60", Offset = "0xBABD60", VA = "0x10BACF60")]
    public JSON_TobiraParamFormatter()
    {
    }

    [Token(Token = "0x6001B67")]
    [Address(RVA = "0xBACBC0", Offset = "0xBAB9C0", VA = "0x10BACBC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TobiraParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B68")]
    [Address(RVA = "0xBAC6E0", Offset = "0xBAB4E0", VA = "0x10BAC6E0", Slot = "5")]
    public JSON_TobiraParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TobiraParam) null;
    }
  }
}
