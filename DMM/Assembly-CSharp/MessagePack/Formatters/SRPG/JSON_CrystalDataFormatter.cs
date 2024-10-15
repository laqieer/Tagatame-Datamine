// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005B9")]
  public sealed class JSON_CrystalDataFormatter : 
    IMessagePackFormatter<JSON_CrystalData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400100A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400100B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A79")]
    [Address(RVA = "0x790740", Offset = "0x78F540", VA = "0x10790740")]
    public JSON_CrystalDataFormatter()
    {
    }

    [Token(Token = "0x6001A7A")]
    [Address(RVA = "0x790500", Offset = "0x78F300", VA = "0x10790500", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A7B")]
    [Address(RVA = "0x7900C0", Offset = "0x78EEC0", VA = "0x107900C0", Slot = "5")]
    public JSON_CrystalData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalData) null;
    }
  }
}
