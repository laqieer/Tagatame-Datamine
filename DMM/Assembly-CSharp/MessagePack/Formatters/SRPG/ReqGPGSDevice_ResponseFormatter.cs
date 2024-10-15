// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGPGSDevice_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008D8")]
  public sealed class ReqGPGSDevice_ResponseFormatter : 
    IMessagePackFormatter<ReqGPGSDevice.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001640")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001641")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023D6")]
    [Address(RVA = "0xDD8760", Offset = "0xDD7560", VA = "0x10DD8760")]
    public ReqGPGSDevice_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023D7")]
    [Address(RVA = "0xDD8610", Offset = "0xDD7410", VA = "0x10DD8610", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGPGSDevice.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023D8")]
    [Address(RVA = "0xDD82E0", Offset = "0xDD70E0", VA = "0x10DD82E0", Slot = "5")]
    public ReqGPGSDevice.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGPGSDevice.Response) null;
    }
  }
}
