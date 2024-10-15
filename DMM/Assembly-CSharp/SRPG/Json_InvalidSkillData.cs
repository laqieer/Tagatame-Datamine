// Decompiled with JetBrains decompiler
// Type: SRPG.Json_InvalidSkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FCE")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_InvalidSkillData
  {
    [Token(Token = "0x40037D9")]
    [FieldOffset(Offset = "0x8")]
    public long job_iid;
    [Token(Token = "0x40037DA")]
    [FieldOffset(Offset = "0x10")]
    public int item_type;
    [Token(Token = "0x40037DB")]
    [FieldOffset(Offset = "0x14")]
    public string skill_iname;

    [Token(Token = "0x60041B2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_InvalidSkillData()
    {
    }
  }
}
