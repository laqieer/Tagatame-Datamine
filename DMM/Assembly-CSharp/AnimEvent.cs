// Decompiled with JetBrains decompiler
// Type: AnimEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200003E")]
public class AnimEvent : ScriptableObject
{
  [Token(Token = "0x4000138")]
  [FieldOffset(Offset = "0xC")]
  public float Start;
  [Token(Token = "0x4000139")]
  [FieldOffset(Offset = "0x10")]
  public float End;
  [Token(Token = "0x400013A")]
  [FieldOffset(Offset = "0x14")]
  protected bool mIsEnd;

  [Token(Token = "0x600017D")]
  [Address(RVA = "0x2CE1C0", Offset = "0x2CCFC0", VA = "0x102CE1C0", Slot = "4")]
  public virtual void OnStart(GameObject go)
  {
  }

  [Token(Token = "0x600017E")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
  public virtual void OnTick(GameObject go, float ratio)
  {
  }

  [Token(Token = "0x600017F")]
  [Address(RVA = "0x2CE1B0", Offset = "0x2CCFB0", VA = "0x102CE1B0", Slot = "6")]
  public virtual void OnEnd(GameObject go)
  {
  }

  [Token(Token = "0x17000027")]
  public bool IsEnd
  {
    [Token(Token = "0x6000180"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000181")]
  [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
  public AnimEvent()
  {
  }
}
