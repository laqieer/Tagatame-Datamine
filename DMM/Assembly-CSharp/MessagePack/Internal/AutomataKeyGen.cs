// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.AutomataKeyGen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Reflection;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000463")]
  public static class AutomataKeyGen
  {
    [Token(Token = "0x4000EF1")]
    [FieldOffset(Offset = "0x0")]
    public static readonly MethodInfo GetKeyMethod;

    [Token(Token = "0x600159A")]
    [Address(RVA = "0x5BC0B0", Offset = "0x5BAEB0", VA = "0x105BC0B0")]
    public static ulong GetKey(ref byte* p, ref int rest) => new ulong();

    [Token(Token = "0x600159B")]
    [Address(RVA = "0x5BB560", Offset = "0x5BA360", VA = "0x105BB560")]
    public static ulong GetKeySafe(byte[] bytes, ref int offset, ref int rest) => new ulong();

    [Token(Token = "0x600159C")]
    [Address(RVA = "0x5BC290", Offset = "0x5BB090", VA = "0x105BC290")]
    static AutomataKeyGen()
    {
    }

    [Token(Token = "0x2000464")]
    public delegate ulong PointerDelegate<T>(ref T p, ref int rest);
  }
}
