// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.UnitBadgeTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000573")]
  public sealed class UnitBadgeTypesFormatter : 
    IMessagePackFormatter<UnitBadgeTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019A7")]
    [Address(RVA = "0x6AF590", Offset = "0x6AE390", VA = "0x106AF590", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      UnitBadgeTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019A8")]
    [Address(RVA = "0x6AF540", Offset = "0x6AE340", VA = "0x106AF540", Slot = "5")]
    public UnitBadgeTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new UnitBadgeTypes();
    }

    [Token(Token = "0x60019A9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitBadgeTypesFormatter()
    {
    }
  }
}
