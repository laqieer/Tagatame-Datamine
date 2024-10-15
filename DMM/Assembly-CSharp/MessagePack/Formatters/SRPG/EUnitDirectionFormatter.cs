// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EUnitDirectionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000581")]
  public sealed class EUnitDirectionFormatter : 
    IMessagePackFormatter<EUnitDirection>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019D1")]
    [Address(RVA = "0x69BFE0", Offset = "0x69ADE0", VA = "0x1069BFE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EUnitDirection value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019D2")]
    [Address(RVA = "0x69BF90", Offset = "0x69AD90", VA = "0x1069BF90", Slot = "5")]
    public EUnitDirection Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EUnitDirection();
    }

    [Token(Token = "0x60019D3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EUnitDirectionFormatter()
    {
    }
  }
}
