// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CollaboSkillParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DE1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CollaboSkillParam
  {
    [Token(Token = "0x4007831")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007832")]
    [FieldOffset(Offset = "0xC")]
    public string uname;
    [Token(Token = "0x4007833")]
    [FieldOffset(Offset = "0x10")]
    public string abid;
    [Token(Token = "0x4007834")]
    [FieldOffset(Offset = "0x14")]
    public string[] lqs;

    [Token(Token = "0x6007A4C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CollaboSkillParam()
    {
    }
  }
}
