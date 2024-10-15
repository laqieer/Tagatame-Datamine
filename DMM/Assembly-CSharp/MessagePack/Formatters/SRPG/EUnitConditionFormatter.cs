// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EUnitConditionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000578")]
  public sealed class EUnitConditionFormatter : 
    IMessagePackFormatter<EUnitCondition>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019B6")]
    [Address(RVA = "0x69BF40", Offset = "0x69AD40", VA = "0x1069BF40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EUnitCondition value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019B7")]
    [Address(RVA = "0x69BEF0", Offset = "0x69ACF0", VA = "0x1069BEF0", Slot = "5")]
    public EUnitCondition Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EUnitCondition();
    }

    [Token(Token = "0x60019B8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EUnitConditionFormatter()
    {
    }
  }
}
