// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptLimitUpItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000617")]
  public sealed class JSON_ConceptLimitUpItemFormatter : 
    IMessagePackFormatter<JSON_ConceptLimitUpItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010C6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010C7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B93")]
    [Address(RVA = "0xBBAE50", Offset = "0xBB9C50", VA = "0x10BBAE50")]
    public JSON_ConceptLimitUpItemFormatter()
    {
    }

    [Token(Token = "0x6001B94")]
    [Address(RVA = "0xBBABC0", Offset = "0xBB99C0", VA = "0x10BBABC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptLimitUpItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B95")]
    [Address(RVA = "0xBBA770", Offset = "0xBB9570", VA = "0x10BBA770", Slot = "5")]
    public JSON_ConceptLimitUpItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptLimitUpItem) null;
    }
  }
}
