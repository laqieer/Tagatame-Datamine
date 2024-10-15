// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqUnitUsedUnit_UnitUsedResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AFB")]
  public sealed class ReqUnitUsedUnit_UnitUsedResponseFormatter : 
    IMessagePackFormatter<ReqUnitUsedUnit.UnitUsedResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A86")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A87")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A3F")]
    [Address(RVA = "0xF2F9D0", Offset = "0xF2E7D0", VA = "0x10F2F9D0")]
    public ReqUnitUsedUnit_UnitUsedResponseFormatter()
    {
    }

    [Token(Token = "0x6002A40")]
    [Address(RVA = "0xF2F6E0", Offset = "0xF2E4E0", VA = "0x10F2F6E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqUnitUsedUnit.UnitUsedResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A41")]
    [Address(RVA = "0xF2F2B0", Offset = "0xF2E0B0", VA = "0x10F2F2B0", Slot = "5")]
    public ReqUnitUsedUnit.UnitUsedResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqUnitUsedUnit.UnitUsedResponse) null;
    }
  }
}
