// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillDuplicateResetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E3C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillDuplicateResetData
  {
    [Token(Token = "0x4007B19")]
    [FieldOffset(Offset = "0x8")]
    public string buff;
    [Token(Token = "0x4007B1A")]
    [FieldOffset(Offset = "0xC")]
    public string skill;
    [Token(Token = "0x4007B1B")]
    [FieldOffset(Offset = "0x10")]
    public int num;

    [Token(Token = "0x6007C0E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillDuplicateResetData()
    {
    }
  }
}
