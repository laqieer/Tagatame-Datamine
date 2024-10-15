// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.Utils.ThreadSafeRandom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace CodeStage.AntiCheat.Utils
{
  [Token(Token = "0x2003687")]
  public class ThreadSafeRandom
  {
    [Token(Token = "0x400FFCA")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Random Global;
    [Token(Token = "0x400FFCB")]
    [ThreadStatic]
    private static Random local;

    [Token(Token = "0x600F423")]
    [Address(RVA = "0xB2F0C0", Offset = "0xB2DEC0", VA = "0x10B2F0C0")]
    public static int Next(int minInclusive, int maxExclusive) => new int();

    [Token(Token = "0x600F424")]
    [Address(RVA = "0xB2F340", Offset = "0xB2E140", VA = "0x10B2F340")]
    public static int Next() => new int();

    [Token(Token = "0x600F425")]
    [Address(RVA = "0xB2F2F0", Offset = "0xB2E0F0", VA = "0x10B2F2F0")]
    public static int Next(int maxExclusive) => new int();

    [Token(Token = "0x600F426")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ThreadSafeRandom()
    {
    }

    [Token(Token = "0x600F427")]
    [Address(RVA = "0xB2F390", Offset = "0xB2E190", VA = "0x10B2F390")]
    static ThreadSafeRandom()
    {
    }
  }
}
