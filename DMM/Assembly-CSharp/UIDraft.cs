﻿// Decompiled with JetBrains decompiler
// Type: UIDraft
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002E6")]
public abstract class UIDraft : MonoBehaviour
{
  [Token(Token = "0x6000F0D")]
  [Address(RVA = "0xE61A80", Offset = "0xE60880", VA = "0x10E61A80")]
  private void Start()
  {
  }

  [Token(Token = "0x6000F0E")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  protected UIDraft()
  {
  }

  [Token(Token = "0x20002E7")]
  public class AutoGenerated : Attribute
  {
    [Token(Token = "0x6000F0F")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public AutoGenerated()
    {
    }
  }

  [Token(Token = "0x20002E8")]
  public class ObsoleteHeader : PropertyAttribute
  {
    [Token(Token = "0x4000C1F")]
    [FieldOffset(Offset = "0xC")]
    public readonly string header;

    [Token(Token = "0x6000F10")]
    [Address(RVA = "0x12A3E10", Offset = "0x12A2C10", VA = "0x112A3E10")]
    public ObsoleteHeader(string header)
    {
    }
  }
}