// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BondRecipeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019BB")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_BondRecipeParam
  {
    [Token(Token = "0x4005E83")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005E84")]
    [FieldOffset(Offset = "0xC")]
    public Json_BondRecipeMatsParam[] mats;

    [Token(Token = "0x6006904")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_BondRecipeParam()
    {
    }
  }
}
