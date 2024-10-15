// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt32Single
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003D7")]
  internal sealed class UInt32Single : ISingleDecoder
  {
    [Token(Token = "0x4000E33")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly ISingleDecoder Instance;

    [Token(Token = "0x60013D4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt32Single()
    {
    }

    [Token(Token = "0x60013D5")]
    [Address(RVA = "0x5CC090", Offset = "0x5CAE90", VA = "0x105CC090", Slot = "4")]
    public float Read(byte[] bytes, int offset, out int readSize) => new float();

    [Token(Token = "0x60013D6")]
    [Address(RVA = "0x5CC120", Offset = "0x5CAF20", VA = "0x105CC120")]
    static UInt32Single()
    {
    }
  }
}
