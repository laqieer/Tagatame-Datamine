// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int16Int32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003F8")]
  internal sealed class Int16Int32 : IInt32Decoder
  {
    [Token(Token = "0x4000E51")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt32Decoder Instance;

    [Token(Token = "0x6001431")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int16Int32()
    {
    }

    [Token(Token = "0x6001432")]
    [Address(RVA = "0x5C1F70", Offset = "0x5C0D70", VA = "0x105C1F70", Slot = "4")]
    public int Read(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x6001433")]
    [Address(RVA = "0x5C1FC0", Offset = "0x5C0DC0", VA = "0x105C1FC0")]
    static Int16Int32()
    {
    }
  }
}
