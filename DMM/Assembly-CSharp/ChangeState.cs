﻿// Decompiled with JetBrains decompiler
// Type: ChangeState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200003F")]
[AddComponentMenu("Common/AnimEvents/ChangeState")]
public class ChangeState : MonoBehaviour
{
  [Token(Token = "0x400013B")]
  [FieldOffset(Offset = "0xC")]
  public ChangeState.StateTypes State;

  [Token(Token = "0x6000182")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public ChangeState()
  {
  }

  [Token(Token = "0x2000040")]
  public enum StateTypes
  {
    [Token(Token = "0x400013D")] Stand,
    [Token(Token = "0x400013E")] Down,
  }
}