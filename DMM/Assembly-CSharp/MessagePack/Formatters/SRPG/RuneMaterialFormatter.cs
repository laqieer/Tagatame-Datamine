// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneMaterialFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008FC")]
  public sealed class RuneMaterialFormatter : 
    IMessagePackFormatter<RuneMaterial>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001688")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001689")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002442")]
    [Address(RVA = "0xDF0F40", Offset = "0xDEFD40", VA = "0x10DF0F40")]
    public RuneMaterialFormatter()
    {
    }

    [Token(Token = "0x6002443")]
    [Address(RVA = "0xDF0A20", Offset = "0xDEF820", VA = "0x10DF0A20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneMaterial value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002444")]
    [Address(RVA = "0xDF0450", Offset = "0xDEF250", VA = "0x10DF0450", Slot = "5")]
    public RuneMaterial Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneMaterial) null;
    }
  }
}
