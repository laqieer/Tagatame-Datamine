﻿// Decompiled with JetBrains decompiler
// Type: SRPG.Json_InvalidSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FCC")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_InvalidSkill
  {
    [Token(Token = "0x40037D5")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x40037D6")]
    [FieldOffset(Offset = "0x10")]
    public Json_InvalidSkillApplyType[] invalid_skills;

    [Token(Token = "0x60041B0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_InvalidSkill()
    {
    }
  }
}