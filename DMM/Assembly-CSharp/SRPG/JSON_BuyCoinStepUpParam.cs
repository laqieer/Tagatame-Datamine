// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_BuyCoinStepUpParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019C6")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_BuyCoinStepUpParam
  {
    [Token(Token = "0x4005EB7")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005EB8")]
    [FieldOffset(Offset = "0xC")]
    public string shop_id;
    [Token(Token = "0x4005EB9")]
    [FieldOffset(Offset = "0x10")]
    public int is_day_reset;
    [Token(Token = "0x4005EBA")]
    [FieldOffset(Offset = "0x14")]
    public int is_platform_common;
    [Token(Token = "0x4005EBB")]
    [FieldOffset(Offset = "0x18")]
    public int unlock_lv;
    [Token(Token = "0x4005EBC")]
    [FieldOffset(Offset = "0x1C")]
    public JSON_BuyCoinStepUpParam.JSON_BuyCoinStepUpProductListParam[] products;

    [Token(Token = "0x600691E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_BuyCoinStepUpParam()
    {
    }

    [Token(Token = "0x20019C7")]
    [MessagePackObject(true)]
    [Serializable]
    public class JSON_BuyCoinStepUpProductListParam
    {
      [Token(Token = "0x4005EBD")]
      [FieldOffset(Offset = "0x8")]
      public string product_id;
      [Token(Token = "0x4005EBE")]
      [FieldOffset(Offset = "0xC")]
      public string reward;
      [Token(Token = "0x4005EBF")]
      [FieldOffset(Offset = "0x10")]
      public string title;
      [Token(Token = "0x4005EC0")]
      [FieldOffset(Offset = "0x14")]
      public string description;
      [Token(Token = "0x4005EC1")]
      [FieldOffset(Offset = "0x18")]
      public int badge;
      [Token(Token = "0x4005EC2")]
      [FieldOffset(Offset = "0x1C")]
      public int img_array_idx;
      [Token(Token = "0x4005EC3")]
      [FieldOffset(Offset = "0x20")]
      public string temp_name;
      [Token(Token = "0x4005EC4")]
      [FieldOffset(Offset = "0x24")]
      public string expr;

      [Token(Token = "0x600691F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_BuyCoinStepUpProductListParam()
      {
      }
    }
  }
}
