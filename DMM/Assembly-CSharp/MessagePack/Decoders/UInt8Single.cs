// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt8Single
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003D5")]
  internal sealed class UInt8Single : ISingleDecoder
  {
    [Token(Token = "0x4000E31")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly ISingleDecoder Instance;

    [Token(Token = "0x60013CE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt8Single()
    {
    }

    [Token(Token = "0x60013CF")]
    [Address(RVA = "0x5CCA00", Offset = "0x5CB800", VA = "0x105CCA00", Slot = "4")]
    public float Read(byte[] bytes, int offset, out int readSize) => new float();

    [Token(Token = "0x60013D0")]
    [Address(RVA = "0x5CCA80", Offset = "0x5CB880", VA = "0x105CCA80")]
    static UInt8Single()
    {
    }
  }
}
