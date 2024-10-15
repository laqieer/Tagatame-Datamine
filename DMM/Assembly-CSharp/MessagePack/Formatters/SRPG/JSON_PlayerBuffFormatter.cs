// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PlayerBuffFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005C7")]
  public sealed class JSON_PlayerBuffFormatter : 
    IMessagePackFormatter<JSON_PlayerBuff>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001026")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001027")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AA3")]
    [Address(RVA = "0x95B2F0", Offset = "0x95A0F0", VA = "0x1095B2F0")]
    public JSON_PlayerBuffFormatter()
    {
    }

    [Token(Token = "0x6001AA4")]
    [Address(RVA = "0x95B0C0", Offset = "0x959EC0", VA = "0x1095B0C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PlayerBuff value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AA5")]
    [Address(RVA = "0x95AD80", Offset = "0x959B80", VA = "0x1095AD80", Slot = "5")]
    public JSON_PlayerBuff Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PlayerBuff) null;
    }
  }
}
