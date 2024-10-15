// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TemporaryFlagsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000572")]
  public sealed class TemporaryFlagsFormatter : 
    IMessagePackFormatter<UnitData.TemporaryFlags>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019A4")]
    [Address(RVA = "0x6AB470", Offset = "0x6AA270", VA = "0x106AB470", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      UnitData.TemporaryFlags value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019A5")]
    [Address(RVA = "0x6AB420", Offset = "0x6AA220", VA = "0x106AB420", Slot = "5")]
    public UnitData.TemporaryFlags Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new UnitData.TemporaryFlags();
    }

    [Token(Token = "0x60019A6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TemporaryFlagsFormatter()
    {
    }
  }
}
