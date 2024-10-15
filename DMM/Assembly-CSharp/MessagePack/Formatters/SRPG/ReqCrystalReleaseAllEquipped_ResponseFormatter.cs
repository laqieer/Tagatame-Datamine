// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCrystalReleaseAllEquipped_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AEC")]
  public sealed class ReqCrystalReleaseAllEquipped_ResponseFormatter : 
    IMessagePackFormatter<ReqCrystalReleaseAllEquipped.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A68")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A69")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A12")]
    [Address(RVA = "0xF26D70", Offset = "0xF25B70", VA = "0x10F26D70")]
    public ReqCrystalReleaseAllEquipped_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A13")]
    [Address(RVA = "0xF26B90", Offset = "0xF25990", VA = "0x10F26B90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCrystalReleaseAllEquipped.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A14")]
    [Address(RVA = "0xF26850", Offset = "0xF25650", VA = "0x10F26850", Slot = "5")]
    public ReqCrystalReleaseAllEquipped.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCrystalReleaseAllEquipped.Response) null;
    }
  }
}
