// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCrystalUpgrade_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200073D")]
  public sealed class ReqCrystalUpgrade_ResponseFormatter : 
    IMessagePackFormatter<ReqCrystalUpgrade.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001312")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001313")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F05")]
    [Address(RVA = "0xC95050", Offset = "0xC93E50", VA = "0x10C95050")]
    public ReqCrystalUpgrade_ResponseFormatter()
    {
    }

    [Token(Token = "0x6001F06")]
    [Address(RVA = "0xC94C70", Offset = "0xC93A70", VA = "0x10C94C70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCrystalUpgrade.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F07")]
    [Address(RVA = "0xC94870", Offset = "0xC93670", VA = "0x10C94870", Slot = "5")]
    public ReqCrystalUpgrade.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCrystalUpgrade.Response) null;
    }
  }
}
