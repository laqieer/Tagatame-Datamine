// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AppealChargeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023B6")]
  [Serializable]
  public class JSON_AppealChargeParam
  {
    [Token(Token = "0x400A14A")]
    [FieldOffset(Offset = "0x8")]
    public JSON_AppealChargeParam.AppealParam fields;

    [Token(Token = "0x6009A88")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AppealChargeParam()
    {
    }

    [Token(Token = "0x20023B7")]
    public class AppealParam
    {
      [Token(Token = "0x400A14B")]
      [FieldOffset(Offset = "0x8")]
      public string appeal_id;
      [Token(Token = "0x400A14C")]
      [FieldOffset(Offset = "0xC")]
      public string before_img_id;
      [Token(Token = "0x400A14D")]
      [FieldOffset(Offset = "0x10")]
      public string after_img_id;
      [Token(Token = "0x400A14E")]
      [FieldOffset(Offset = "0x14")]
      public string start_at;
      [Token(Token = "0x400A14F")]
      [FieldOffset(Offset = "0x18")]
      public string end_at;

      [Token(Token = "0x6009A89")]
      [Address(RVA = "0x5E07C0", Offset = "0x5DF5C0", VA = "0x105E07C0")]
      public AppealParam()
      {
      }
    }
  }
}
