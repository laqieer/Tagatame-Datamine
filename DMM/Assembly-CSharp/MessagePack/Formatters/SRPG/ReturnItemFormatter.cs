// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReturnItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000771")]
  public sealed class ReturnItemFormatter : IMessagePackFormatter<ReturnItem>, IMessagePackFormatter
  {
    [Token(Token = "0x400137A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400137B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FA1")]
    [Address(RVA = "0xCB7320", Offset = "0xCB6120", VA = "0x10CB7320")]
    public ReturnItemFormatter()
    {
    }

    [Token(Token = "0x6001FA2")]
    [Address(RVA = "0xCB71A0", Offset = "0xCB5FA0", VA = "0x10CB71A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReturnItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FA3")]
    [Address(RVA = "0xCB6E50", Offset = "0xCB5C50", VA = "0x10CB6E50", Slot = "5")]
    public ReturnItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReturnItem) null;
    }
  }
}
