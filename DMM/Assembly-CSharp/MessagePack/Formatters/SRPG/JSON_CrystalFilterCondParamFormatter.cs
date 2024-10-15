// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalFilterCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006D7")]
  public sealed class JSON_CrystalFilterCondParamFormatter : 
    IMessagePackFormatter<JSON_CrystalFilterCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001246")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001247")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DD3")]
    [Address(RVA = "0xC0DCE0", Offset = "0xC0CAE0", VA = "0x10C0DCE0")]
    public JSON_CrystalFilterCondParamFormatter()
    {
    }

    [Token(Token = "0x6001DD4")]
    [Address(RVA = "0xC0DA80", Offset = "0xC0C880", VA = "0x10C0DA80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalFilterCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DD5")]
    [Address(RVA = "0xC0D650", Offset = "0xC0C450", VA = "0x10C0D650", Slot = "5")]
    public JSON_CrystalFilterCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalFilterCondParam) null;
    }
  }
}
