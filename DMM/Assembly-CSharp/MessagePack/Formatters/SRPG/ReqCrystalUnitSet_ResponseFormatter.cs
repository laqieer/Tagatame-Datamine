// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCrystalUnitSet_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000961")]
  public sealed class ReqCrystalUnitSet_ResponseFormatter : 
    IMessagePackFormatter<ReqCrystalUnitSet.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001752")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001753")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002571")]
    [Address(RVA = "0xE19470", Offset = "0xE18270", VA = "0x10E19470")]
    public ReqCrystalUnitSet_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002572")]
    [Address(RVA = "0xE19370", Offset = "0xE18170", VA = "0x10E19370", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCrystalUnitSet.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002573")]
    [Address(RVA = "0xE190A0", Offset = "0xE17EA0", VA = "0x10E190A0", Slot = "5")]
    public ReqCrystalUnitSet.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCrystalUnitSet.Response) null;
    }
  }
}
