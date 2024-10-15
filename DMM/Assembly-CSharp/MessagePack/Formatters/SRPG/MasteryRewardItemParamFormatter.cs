// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MasteryRewardItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000916")]
  public sealed class MasteryRewardItemParamFormatter : 
    IMessagePackFormatter<MasteryRewardItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016BC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016BD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002490")]
    [Address(RVA = "0xE03480", Offset = "0xE02280", VA = "0x10E03480")]
    public MasteryRewardItemParamFormatter()
    {
    }

    [Token(Token = "0x6002491")]
    [Address(RVA = "0xE032E0", Offset = "0xE020E0", VA = "0x10E032E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MasteryRewardItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002492")]
    [Address(RVA = "0xE02F60", Offset = "0xE01D60", VA = "0x10E02F60", Slot = "5")]
    public MasteryRewardItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MasteryRewardItemParam) null;
    }
  }
}
