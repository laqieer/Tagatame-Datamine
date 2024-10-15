// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EUnitTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000555")]
  public sealed class EUnitTypeFormatter : IMessagePackFormatter<EUnitType>, IMessagePackFormatter
  {
    [Token(Token = "0x600194D")]
    [Address(RVA = "0x69C1C0", Offset = "0x69AFC0", VA = "0x1069C1C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EUnitType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600194E")]
    [Address(RVA = "0x69C170", Offset = "0x69AF70", VA = "0x1069C170", Slot = "5")]
    public EUnitType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EUnitType();
    }

    [Token(Token = "0x600194F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EUnitTypeFormatter()
    {
    }
  }
}
