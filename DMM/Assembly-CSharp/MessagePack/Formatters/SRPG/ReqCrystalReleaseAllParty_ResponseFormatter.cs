// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCrystalReleaseAllParty_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005C0")]
  public sealed class ReqCrystalReleaseAllParty_ResponseFormatter : 
    IMessagePackFormatter<ReqCrystalReleaseAllParty.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001018")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001019")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A8E")]
    [Address(RVA = "0x7A44A0", Offset = "0x7A32A0", VA = "0x107A44A0")]
    public ReqCrystalReleaseAllParty_ResponseFormatter()
    {
    }

    [Token(Token = "0x6001A8F")]
    [Address(RVA = "0x7A4270", Offset = "0x7A3070", VA = "0x107A4270", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCrystalReleaseAllParty.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A90")]
    [Address(RVA = "0x7A3F30", Offset = "0x7A2D30", VA = "0x107A3F30", Slot = "5")]
    public ReqCrystalReleaseAllParty.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCrystalReleaseAllParty.Response) null;
    }
  }
}
