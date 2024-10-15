// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCrystalDisassemble_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000727")]
  public sealed class ReqCrystalDisassemble_ResponseFormatter : 
    IMessagePackFormatter<ReqCrystalDisassemble.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012E6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012E7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EC3")]
    [Address(RVA = "0xC66670", Offset = "0xC65470", VA = "0x10C66670")]
    public ReqCrystalDisassemble_ResponseFormatter()
    {
    }

    [Token(Token = "0x6001EC4")]
    [Address(RVA = "0xC66450", Offset = "0xC65250", VA = "0x10C66450", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCrystalDisassemble.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EC5")]
    [Address(RVA = "0xC660B0", Offset = "0xC64EB0", VA = "0x10C660B0", Slot = "5")]
    public ReqCrystalDisassemble.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCrystalDisassemble.Response) null;
    }
  }
}
