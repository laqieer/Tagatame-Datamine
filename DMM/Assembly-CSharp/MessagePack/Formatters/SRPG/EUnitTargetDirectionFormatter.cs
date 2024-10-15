// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EUnitTargetDirectionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000575")]
  public sealed class EUnitTargetDirectionFormatter : 
    IMessagePackFormatter<EUnitTargetDirection>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019AD")]
    [Address(RVA = "0x69C120", Offset = "0x69AF20", VA = "0x1069C120", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EUnitTargetDirection value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019AE")]
    [Address(RVA = "0x69C0D0", Offset = "0x69AED0", VA = "0x1069C0D0", Slot = "5")]
    public EUnitTargetDirection Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EUnitTargetDirection();
    }

    [Token(Token = "0x60019AF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EUnitTargetDirectionFormatter()
    {
    }
  }
}
