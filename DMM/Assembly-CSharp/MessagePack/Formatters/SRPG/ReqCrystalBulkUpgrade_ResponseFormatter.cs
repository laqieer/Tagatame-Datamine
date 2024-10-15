// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCrystalBulkUpgrade_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ABD")]
  public sealed class ReqCrystalBulkUpgrade_ResponseFormatter : 
    IMessagePackFormatter<ReqCrystalBulkUpgrade.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A0A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A0B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002985")]
    [Address(RVA = "0xF116F0", Offset = "0xF104F0", VA = "0x10F116F0")]
    public ReqCrystalBulkUpgrade_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002986")]
    [Address(RVA = "0xF113C0", Offset = "0xF101C0", VA = "0x10F113C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCrystalBulkUpgrade.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002987")]
    [Address(RVA = "0xF10FC0", Offset = "0xF0FDC0", VA = "0x10F10FC0", Slot = "5")]
    public ReqCrystalBulkUpgrade.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCrystalBulkUpgrade.Response) null;
    }
  }
}
