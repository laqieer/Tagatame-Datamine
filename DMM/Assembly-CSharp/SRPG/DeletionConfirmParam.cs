﻿// Decompiled with JetBrains decompiler
// Type: SRPG.DeletionConfirmParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E35")]
  [Serializable]
  public class DeletionConfirmParam
  {
    [Token(Token = "0x400E847")]
    [FieldOffset(Offset = "0x8")]
    public string deletion_flow_token;
    [Token(Token = "0x400E848")]
    [FieldOffset(Offset = "0xC")]
    public int confirm_progress;

    [Token(Token = "0x600DA79")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DeletionConfirmParam()
    {
    }
  }
}