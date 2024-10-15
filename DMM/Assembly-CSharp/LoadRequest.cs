// Decompiled with JetBrains decompiler
// Type: LoadRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x200008B")]
public class LoadRequest : IEnumerator
{
  [Token(Token = "0x600034C")]
  [Address(RVA = "0xB8D510", Offset = "0xB8C310", VA = "0x10B8D510")]
  public Coroutine StartCoroutine() => (Coroutine) null;

  [Token(Token = "0x17000082")]
  public virtual Object asset
  {
    [Token(Token = "0x600034D"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "7")] get
    {
      return (Object) null;
    }
  }

  [Token(Token = "0x17000083")]
  public virtual bool isDone
  {
    [Token(Token = "0x600034E"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "8")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x600034F")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
  public void Reset()
  {
  }

  [Token(Token = "0x6000350")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "9")]
  public virtual bool MoveNext() => new bool();

  [Token(Token = "0x17000084")]
  public object Current
  {
    [Token(Token = "0x6000351"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
    {
      return (object) null;
    }
  }

  [Token(Token = "0x17000085")]
  public virtual float progress
  {
    [Token(Token = "0x6000352"), Address(RVA = "0xB8D670", Offset = "0xB8C470", VA = "0x10B8D670", Slot = "10")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x6000353")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "11")]
  public virtual void KeepSourceAlive()
  {
  }

  [Token(Token = "0x6000354")]
  [Address(RVA = "0xB8D5B0", Offset = "0xB8C3B0", VA = "0x10B8D5B0")]
  public static void UntrackTextComponents(Object obj)
  {
  }

  [Token(Token = "0x6000355")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public LoadRequest()
  {
  }
}
