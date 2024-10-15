// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitJobOverwriteParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005D9")]
  public sealed class JSON_UnitJobOverwriteParamFormatter : 
    IMessagePackFormatter<JSON_UnitJobOverwriteParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400104A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400104B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AD9")]
    [Address(RVA = "0xA6AB40", Offset = "0xA69940", VA = "0x10A6AB40")]
    public JSON_UnitJobOverwriteParamFormatter()
    {
    }

    [Token(Token = "0x6001ADA")]
    [Address(RVA = "0xA6A710", Offset = "0xA69510", VA = "0x10A6A710", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitJobOverwriteParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001ADB")]
    [Address(RVA = "0xA6A130", Offset = "0xA68F30", VA = "0x10A6A130", Slot = "5")]
    public JSON_UnitJobOverwriteParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitJobOverwriteParam) null;
    }
  }
}
