// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_UnitSkillDistanceFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007BC")]
  public sealed class Unit_UnitSkillDistanceFormatter : 
    IMessagePackFormatter<Unit.UnitSkillDistance>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001408")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001409")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002082")]
    [Address(RVA = "0xD13670", Offset = "0xD12470", VA = "0x10D13670")]
    public Unit_UnitSkillDistanceFormatter()
    {
    }

    [Token(Token = "0x6002083")]
    [Address(RVA = "0xD133D0", Offset = "0xD121D0", VA = "0x10D133D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.UnitSkillDistance value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002084")]
    [Address(RVA = "0xD12FF0", Offset = "0xD11DF0", VA = "0x10D12FF0", Slot = "5")]
    public Unit.UnitSkillDistance Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.UnitSkillDistance) null;
    }
  }
}
