// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TobiraLearnAbilityParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D65")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TobiraLearnAbilityParam
  {
    [Token(Token = "0x40073BD")]
    [FieldOffset(Offset = "0x8")]
    public string abil_iname;
    [Token(Token = "0x40073BE")]
    [FieldOffset(Offset = "0xC")]
    public int learn_lv;
    [Token(Token = "0x40073BF")]
    [FieldOffset(Offset = "0x10")]
    public int add_type;
    [Token(Token = "0x40073C0")]
    [FieldOffset(Offset = "0x14")]
    public string target_job;
    [Token(Token = "0x40073C1")]
    [FieldOffset(Offset = "0x18")]
    public string abil_overwrite;

    [Token(Token = "0x600785D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TobiraLearnAbilityParam()
    {
    }
  }
}
