// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int32Int32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003F9")]
  internal sealed class Int32Int32 : IInt32Decoder
  {
    [Token(Token = "0x4000E52")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt32Decoder Instance;

    [Token(Token = "0x6001434")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int32Int32()
    {
    }

    [Token(Token = "0x6001435")]
    [Address(RVA = "0x5BAC30", Offset = "0x5B9A30", VA = "0x105BAC30", Slot = "4")]
    public int Read(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x6001436")]
    [Address(RVA = "0x5C22A0", Offset = "0x5C10A0", VA = "0x105C22A0")]
    static Int32Int32()
    {
    }
  }
}
