// Decompiled with JetBrains decompiler
// Type: SRPG.ExpireItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ADF")]
  [Serializable]
  public class ExpireItemParam
  {
    [Token(Token = "0x40063AD")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40063AE")]
    [FieldOffset(Offset = "0xC")]
    public int num;

    [Token(Token = "0x6006EB3")]
    [Address(RVA = "0x3626F0", Offset = "0x3614F0", VA = "0x103626F0")]
    public void Deserialize(Json_ExpireItem json)
    {
    }

    [Token(Token = "0x6006EB4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ExpireItemParam()
    {
    }
  }
}
