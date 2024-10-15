// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalAddLimitStatusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006DC")]
  public sealed class JSON_CrystalAddLimitStatusFormatter : 
    IMessagePackFormatter<JSON_CrystalAddLimitStatus>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001250")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001251")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DE2")]
    [Address(RVA = "0xC0D3F0", Offset = "0xC0C1F0", VA = "0x10C0D3F0")]
    public JSON_CrystalAddLimitStatusFormatter()
    {
    }

    [Token(Token = "0x6001DE3")]
    [Address(RVA = "0xC0D250", Offset = "0xC0C050", VA = "0x10C0D250", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalAddLimitStatus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DE4")]
    [Address(RVA = "0xC0CED0", Offset = "0xC0BCD0", VA = "0x10C0CED0", Slot = "5")]
    public JSON_CrystalAddLimitStatus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalAddLimitStatus) null;
    }
  }
}
