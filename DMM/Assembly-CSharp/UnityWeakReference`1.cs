// Decompiled with JetBrains decompiler
// Type: UnityWeakReference`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x2000083")]
internal class UnityWeakReference<T> : WeakReference where T : UnityEngine.Object
{
  [Token(Token = "0x60002FC")]
  public UnityWeakReference(T target)
  {
  }

  [Token(Token = "0x17000077")]
  public override bool IsAlive
  {
    [Token(Token = "0x60002FD")] get => new bool();
  }

  [Token(Token = "0x17000078")]
  public T Target
  {
    [Token(Token = "0x60002FE")] get => (T) null;
    [Token(Token = "0x60002FF")] set
    {
    }
  }

  [Token(Token = "0x6000300")]
  public bool TryGetTarget(out T target) => new bool();
}
