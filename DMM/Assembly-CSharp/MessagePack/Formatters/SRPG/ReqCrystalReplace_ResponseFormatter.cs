// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCrystalReplace_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009F5")]
  public sealed class ReqCrystalReplace_ResponseFormatter : 
    IMessagePackFormatter<ReqCrystalReplace.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400187A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400187B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600272D")]
    [Address(RVA = "0xE8C570", Offset = "0xE8B370", VA = "0x10E8C570")]
    public ReqCrystalReplace_ResponseFormatter()
    {
    }

    [Token(Token = "0x600272E")]
    [Address(RVA = "0xE8C400", Offset = "0xE8B200", VA = "0x10E8C400", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCrystalReplace.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600272F")]
    [Address(RVA = "0xE8C130", Offset = "0xE8AF30", VA = "0x10E8C130", Slot = "5")]
    public ReqCrystalReplace.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCrystalReplace.Response) null;
    }
  }
}
