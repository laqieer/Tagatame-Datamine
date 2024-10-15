// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000797")]
  public sealed class BondDataFormatter : IMessagePackFormatter<BondData>, IMessagePackFormatter
  {
    [Token(Token = "0x40013C6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013C7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002013")]
    [Address(RVA = "0xCD7CB0", Offset = "0xCD6AB0", VA = "0x10CD7CB0")]
    public BondDataFormatter()
    {
    }

    [Token(Token = "0x6002014")]
    [Address(RVA = "0xCD7B80", Offset = "0xCD6980", VA = "0x10CD7B80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002015")]
    [Address(RVA = "0xCD78A0", Offset = "0xCD66A0", VA = "0x10CD78A0", Slot = "5")]
    public BondData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondData) null;
    }
  }
}
