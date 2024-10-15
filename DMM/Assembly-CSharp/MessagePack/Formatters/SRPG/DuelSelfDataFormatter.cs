// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.DuelSelfDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A07")]
  public sealed class DuelSelfDataFormatter : 
    IMessagePackFormatter<DuelSelfData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400189E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400189F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002763")]
    [Address(RVA = "0xE95E20", Offset = "0xE94C20", VA = "0x10E95E20")]
    public DuelSelfDataFormatter()
    {
    }

    [Token(Token = "0x6002764")]
    [Address(RVA = "0xE95B10", Offset = "0xE94910", VA = "0x10E95B10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DuelSelfData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002765")]
    [Address(RVA = "0xE95750", Offset = "0xE94550", VA = "0x10E95750", Slot = "5")]
    public DuelSelfData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DuelSelfData) null;
    }
  }
}
