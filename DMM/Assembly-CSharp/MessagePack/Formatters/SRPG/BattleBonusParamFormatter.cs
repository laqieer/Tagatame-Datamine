// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BattleBonusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200076A")]
  public sealed class BattleBonusParamFormatter : 
    IMessagePackFormatter<BattleBonusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400136C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400136D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F8C")]
    [Address(RVA = "0xCAB550", Offset = "0xCAA350", VA = "0x10CAB550")]
    public BattleBonusParamFormatter()
    {
    }

    [Token(Token = "0x6001F8D")]
    [Address(RVA = "0xCAB450", Offset = "0xCAA250", VA = "0x10CAB450", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BattleBonusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F8E")]
    [Address(RVA = "0xCAB180", Offset = "0xCA9F80", VA = "0x10CAB180", Slot = "5")]
    public BattleBonusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BattleBonusParam) null;
    }
  }
}
