// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SimpleQuestDropParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D23")]
  [Serializable]
  public class JSON_SimpleQuestDropParam
  {
    [Token(Token = "0x4007242")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007243")]
    [FieldOffset(Offset = "0xC")]
    public string[] questlist;

    [Token(Token = "0x6007785")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SimpleQuestDropParam()
    {
    }
  }
}
