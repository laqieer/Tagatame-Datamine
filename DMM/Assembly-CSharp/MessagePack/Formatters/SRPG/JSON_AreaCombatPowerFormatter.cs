// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AreaCombatPowerFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000733")]
  public sealed class JSON_AreaCombatPowerFormatter : 
    IMessagePackFormatter<JSON_AreaCombatPower>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012FE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012FF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EE7")]
    [Address(RVA = "0xC84580", Offset = "0xC83380", VA = "0x10C84580")]
    public JSON_AreaCombatPowerFormatter()
    {
    }

    [Token(Token = "0x6001EE8")]
    [Address(RVA = "0xC84450", Offset = "0xC83250", VA = "0x10C84450", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AreaCombatPower value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EE9")]
    [Address(RVA = "0xC84140", Offset = "0xC82F40", VA = "0x10C84140", Slot = "5")]
    public JSON_AreaCombatPower Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AreaCombatPower) null;
    }
  }
}
