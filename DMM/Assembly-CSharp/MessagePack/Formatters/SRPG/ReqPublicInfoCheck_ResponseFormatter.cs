// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqPublicInfoCheck_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009EF")]
  public sealed class ReqPublicInfoCheck_ResponseFormatter : 
    IMessagePackFormatter<ReqPublicInfoCheck.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400186E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400186F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600271B")]
    [Address(RVA = "0xE90F70", Offset = "0xE8FD70", VA = "0x10E90F70")]
    public ReqPublicInfoCheck_ResponseFormatter()
    {
    }

    [Token(Token = "0x600271C")]
    [Address(RVA = "0xE90EB0", Offset = "0xE8FCB0", VA = "0x10E90EB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqPublicInfoCheck.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600271D")]
    [Address(RVA = "0xE90C10", Offset = "0xE8FA10", VA = "0x10E90C10", Slot = "5")]
    public ReqPublicInfoCheck.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqPublicInfoCheck.Response) null;
    }
  }
}
