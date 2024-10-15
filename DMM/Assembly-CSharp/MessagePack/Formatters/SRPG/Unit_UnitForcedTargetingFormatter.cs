// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_UnitForcedTargetingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007B6")]
  public sealed class Unit_UnitForcedTargetingFormatter : 
    IMessagePackFormatter<Unit.UnitForcedTargeting>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013FC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013FD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002070")]
    [Address(RVA = "0xD0EE30", Offset = "0xD0DC30", VA = "0x10D0EE30")]
    public Unit_UnitForcedTargetingFormatter()
    {
    }

    [Token(Token = "0x6002071")]
    [Address(RVA = "0xD0ED00", Offset = "0xD0DB00", VA = "0x10D0ED00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.UnitForcedTargeting value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002072")]
    [Address(RVA = "0xD0E9F0", Offset = "0xD0D7F0", VA = "0x10D0E9F0", Slot = "5")]
    public Unit.UnitForcedTargeting Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.UnitForcedTargeting) null;
    }
  }
}
