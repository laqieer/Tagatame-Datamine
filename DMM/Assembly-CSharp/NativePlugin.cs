// Decompiled with JetBrains decompiler
// Type: NativePlugin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;

#nullable disable
[Token(Token = "0x200007B")]
public static class NativePlugin
{
  [Token(Token = "0x60002CA")]
  [Address(RVA = "0x2DC1B0", Offset = "0x2DAFB0", VA = "0x102DC1B0")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  public static extern IntPtr DecompressFile(string path, out int size);

  [Token(Token = "0x60002CB")]
  [Address(RVA = "0x2DC240", Offset = "0x2DB040", VA = "0x102DC240")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  public static extern void FreePtr(IntPtr ptr);
}
