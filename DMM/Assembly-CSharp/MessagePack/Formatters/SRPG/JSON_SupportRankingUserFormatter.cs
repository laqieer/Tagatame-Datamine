// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SupportRankingUserFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008B0")]
  public sealed class JSON_SupportRankingUserFormatter : 
    IMessagePackFormatter<JSON_SupportRankingUser>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015F0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015F1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600235E")]
    [Address(RVA = "0xDB88F0", Offset = "0xDB76F0", VA = "0x10DB88F0")]
    public JSON_SupportRankingUserFormatter()
    {
    }

    [Token(Token = "0x600235F")]
    [Address(RVA = "0xDB86C0", Offset = "0xDB74C0", VA = "0x10DB86C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SupportRankingUser value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002360")]
    [Address(RVA = "0xDB8380", Offset = "0xDB7180", VA = "0x10DB8380", Slot = "5")]
    public JSON_SupportRankingUser Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SupportRankingUser) null;
    }
  }
}
