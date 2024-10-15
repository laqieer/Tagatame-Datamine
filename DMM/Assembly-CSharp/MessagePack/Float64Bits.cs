// Decompiled with JetBrains decompiler
// Type: MessagePack.Float64Bits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Runtime.InteropServices;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x200034D")]
  [StructLayout(LayoutKind.Explicit)]
  internal struct Float64Bits
  {
    [Token(Token = "0x4000D29")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    public readonly double Value;
    [Token(Token = "0x4000D2A")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    public readonly byte Byte0;
    [Token(Token = "0x4000D2B")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x1")]
    public readonly byte Byte1;
    [Token(Token = "0x4000D2C")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x2")]
    public readonly byte Byte2;
    [Token(Token = "0x4000D2D")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x3")]
    public readonly byte Byte3;
    [Token(Token = "0x4000D2E")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x4")]
    public readonly byte Byte4;
    [Token(Token = "0x4000D2F")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x5")]
    public readonly byte Byte5;
    [Token(Token = "0x4000D30")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x6")]
    public readonly byte Byte6;
    [Token(Token = "0x4000D31")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x7")]
    public readonly byte Byte7;

    [Token(Token = "0x600118B")]
    [Address(RVA = "0x2EC990", Offset = "0x2EB790", VA = "0x102EC990")]
    public Float64Bits(double value)
    {
    }

    [Token(Token = "0x600118C")]
    [Address(RVA = "0x2EC810", Offset = "0x2EB610", VA = "0x102EC810")]
    public Float64Bits(byte[] bigEndianBytes, int offset)
    {
    }
  }
}
