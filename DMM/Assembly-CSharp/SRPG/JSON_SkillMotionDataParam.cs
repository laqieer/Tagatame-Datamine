// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillMotionDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E48")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillMotionDataParam
  {
    [Token(Token = "0x4007B4C")]
    [FieldOffset(Offset = "0x8")]
    public string[] unit_ids;
    [Token(Token = "0x4007B4D")]
    [FieldOffset(Offset = "0xC")]
    public string[] job_ids;
    [Token(Token = "0x4007B4E")]
    [FieldOffset(Offset = "0x10")]
    public string motnm;
    [Token(Token = "0x4007B4F")]
    [FieldOffset(Offset = "0x14")]
    public int isbtl;
    [Token(Token = "0x4007B50")]
    [FieldOffset(Offset = "0x18")]
    public string effnm;

    [Token(Token = "0x6007C43")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillMotionDataParam()
    {
    }
  }
}
