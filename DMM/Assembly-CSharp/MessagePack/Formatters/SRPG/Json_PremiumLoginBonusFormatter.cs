// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_PremiumLoginBonusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200086C")]
  public sealed class Json_PremiumLoginBonusFormatter : 
    IMessagePackFormatter<Json_PremiumLoginBonus>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001568")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001569")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002292")]
    [Address(RVA = "0xD95B10", Offset = "0xD94910", VA = "0x10D95B10")]
    public Json_PremiumLoginBonusFormatter()
    {
    }

    [Token(Token = "0x6002293")]
    [Address(RVA = "0xD957D0", Offset = "0xD945D0", VA = "0x10D957D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_PremiumLoginBonus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002294")]
    [Address(RVA = "0xD953C0", Offset = "0xD941C0", VA = "0x10D953C0", Slot = "5")]
    public Json_PremiumLoginBonus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_PremiumLoginBonus) null;
    }
  }
}
