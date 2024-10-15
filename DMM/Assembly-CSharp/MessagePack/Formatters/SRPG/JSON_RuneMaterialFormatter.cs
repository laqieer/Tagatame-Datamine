// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneMaterialFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200067D")]
  public sealed class JSON_RuneMaterialFormatter : 
    IMessagePackFormatter<JSON_RuneMaterial>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001192")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001193")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CC5")]
    [Address(RVA = "0xBEB710", Offset = "0xBEA510", VA = "0x10BEB710")]
    public JSON_RuneMaterialFormatter()
    {
    }

    [Token(Token = "0x6001CC6")]
    [Address(RVA = "0xBEB270", Offset = "0xBEA070", VA = "0x10BEB270", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneMaterial value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CC7")]
    [Address(RVA = "0xBEACB0", Offset = "0xBE9AB0", VA = "0x10BEACB0", Slot = "5")]
    public JSON_RuneMaterial Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneMaterial) null;
    }
  }
}
