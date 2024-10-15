// Decompiled with JetBrains decompiler
// Type: Gsc.Support.SupportExtentions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Gsc.Support
{
  [Token(Token = "0x2003554")]
  public static class SupportExtentions
  {
    [Token(Token = "0x600EC64")]
    public static T Get<T>(this WeakReference self) => (T) null;

    [Token(Token = "0x600EC65")]
    public static bool TryGet<T>(this WeakReference self, out T value) => new bool();

    [Token(Token = "0x600EC66")]
    public static WeakReference Set<T>(this WeakReference self, T obj) => (WeakReference) null;
  }
}
