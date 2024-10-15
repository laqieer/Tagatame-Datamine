// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqJukeBox_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AD6")]
  public sealed class ReqJukeBox_ResponseFormatter : 
    IMessagePackFormatter<ReqJukeBox.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A3C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A3D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029D0")]
    [Address(RVA = "0xF15700", Offset = "0xF14500", VA = "0x10F15700")]
    public ReqJukeBox_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029D1")]
    [Address(RVA = "0xF154D0", Offset = "0xF142D0", VA = "0x10F154D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqJukeBox.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029D2")]
    [Address(RVA = "0xF15190", Offset = "0xF13F90", VA = "0x10F15190", Slot = "5")]
    public ReqJukeBox.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqJukeBox.Response) null;
    }
  }
}
