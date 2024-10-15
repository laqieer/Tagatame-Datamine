// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RaidRewardTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000590")]
  public sealed class RaidRewardTypeFormatter : 
    IMessagePackFormatter<RaidRewardType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019FE")]
    [Address(RVA = "0x7A3EE0", Offset = "0x7A2CE0", VA = "0x107A3EE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RaidRewardType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019FF")]
    [Address(RVA = "0x7A3E90", Offset = "0x7A2C90", VA = "0x107A3E90", Slot = "5")]
    public RaidRewardType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new RaidRewardType();
    }

    [Token(Token = "0x6001A00")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidRewardTypeFormatter()
    {
    }
  }
}
