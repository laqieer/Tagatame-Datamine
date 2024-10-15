// Decompiled with JetBrains decompiler
// Type: SRPG.Json_JobSelectable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200100C")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_JobSelectable
  {
    [Token(Token = "0x400390E")]
    [FieldOffset(Offset = "0x8")]
    public long[] abils;
    [Token(Token = "0x400390F")]
    [FieldOffset(Offset = "0xC")]
    public long[] artifacts;
    [Token(Token = "0x4003910")]
    [FieldOffset(Offset = "0x10")]
    public Json_InspirationSkillExt[] inspiration_skills;

    [Token(Token = "0x6004270")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_JobSelectable()
    {
    }
  }
}
